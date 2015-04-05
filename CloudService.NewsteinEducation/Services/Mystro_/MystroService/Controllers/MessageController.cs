using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using MystroService.DataObjects;
using MystroService.Models;
using Microsoft;
using System;
using System.Text;
using System.Net;

namespace MystroService.Controllers
{
    public class MessageController : TableController<Message>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MystroContext context = new MystroContext();
            DomainManager = new EntityDomainManager<Message>(context, Request, Services);
        }

        public IQueryable<Message> GetAllMessages()
        {
            return Query();
        }

        public IQueryable<Message> GetAllMessagesForUser(string userName, string lang)
        {
   
           
            // Get messages for user
            var query = Query().ToList().Where(m => m.From == userName || m.To == userName);

            // Improved support for unicode
            Console.OutputEncoding = Encoding.UTF8;

            // Call a InitializeTranslatorContainer to get a TranslatorContainer
            // that is configured to use your account.
            TranslatorContainer tc = InitializeTranslatorContainer();

            // PickRandomLanguage encapsulates the work required to detect all
            // languages supported by the service and then to pick one at random
            var targetLanguage = tc.GetLanguagesForTranslation().ToList().Where(x => x.Code == lang).FirstOrDefault();

            foreach (Message m in query)
            {
                if (m.From != userName)
                {
                    // DetectSourceLanguage encapsulates the work required for language
                    // detection
                    var sourceLanguage = DetectSourceLanguage(tc, m.Msg);

                    // Handle the error condition
                    if (sourceLanguage == null)
                    {
                        continue;
                    }

                    // TranslateString encapsulates the work required to translate
                    // a string from the source language to the target language
                    var translationResult = TranslateString(tc, m.Msg, sourceLanguage, targetLanguage);

                    // Handle the error condition
                    if (translationResult != null)
                    {
                        m.Msg = translationResult.Text;
                    }
                }
            }

            return query.AsQueryable();
        }

        public SingleResult<Message> GetMessage(string id)
        {
            return Lookup(id);
        }

        public Task<Message> PatchMessage(string id, Delta<Message> patch)
        {
            return UpdateAsync(id, patch);
        }

        public async Task<IHttpActionResult> PostMessage(Message item)
        {
            Message current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        public Task DeleteMessage(string id)
        {
            return DeleteAsync(id);
        }

        /// <summary>
        /// Creates an instance of a TranslatorContainer that calls the public 
        /// production MicrosoftTranslator service
        /// </summary>
        /// <returns>The generatet TranslatorContainer</returns>
        private static TranslatorContainer InitializeTranslatorContainer()
        {
            // this is the service root uri for the Microsoft Translator service 
            var serviceRootUri = new Uri("https://api.datamarket.azure.com/Bing/MicrosoftTranslator/");

            // this is the Account Key I generated for this app
            var accountKey = "I0IKi2+1RxbdEpRHRifByaJlLyqYgA7srH/2NT0MVE8";

            // Replace the account key above with your own and then delete 
            // the following line of code. You can get your own account key
            // for from here: https://datamarket.azure.com/account/keys

            // the TranslatorContainer gives us access to the Microsoft Translator services
            var tc = new Microsoft.TranslatorContainer(serviceRootUri);

            // Give the TranslatorContainer access to your subscription
            tc.SetCredentials = new NetworkCredential(accountKey, accountKey);
            return tc;
        }

        /// <summary>
        /// Uses the TranslatorContainer to identify the Language in which inputString was written
        /// </summary>
        /// <param name="tc">The TranslatorContainer to use</param>
        /// <param name="inputString">The string to identify</param>
        /// <returns>The Language Code for a language that this string could represent,
        /// or null if one is not found.</returns>
        private static DetectedLanguage DetectSourceLanguage(TranslatorContainer tc, string inputString)
        {
            // calling Detect gives us a DataServiceQuery which we can use to call the service
            var translateQuery = tc.Detect(inputString);

            // since this is a console application, we do not want to do an asynchronous 
            // call to the service. Otherwise, the program thread would likely terminate
            // before the result came back, causing our app to appear broken.
            var detectedLanguages = translateQuery.Execute().ToList();

            // only continue if the Microsoft Translator identified the source language
            // if there are multiple, let's go with the first.
            if (detectedLanguages.Count() > 0)
            {
                return detectedLanguages.First();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Asks the service represented by the TranslatorContainer for a list
        /// of all supported languages and then picks one at random.
        /// </summary>
        /// <param name="tc">The TranslatorContainer to use.</param>
        /// <returns>A randomly selected Language.</returns>
        private static Language PickRandomLanguage(TranslatorContainer tc)
        {
            // Used to generate a random index
            var random = new Random();

            // Generate the query
            var languagesForTranslationQuery = tc.GetLanguagesForTranslation();

            // Call the query to get the results as an Array
            var availableLanguages = languagesForTranslationQuery.Execute().ToArray();

            // Generate a random index between 0 and the total number of items in the array
            var randomIndex = random.Next(availableLanguages.Count());

            // Select the randomIndex'th value from the array
            var selectedLanguage = availableLanguages[randomIndex];

            return selectedLanguage;
        }

        /// <summary>
        /// Uses the TranslatorContainer to translate inputString from sourceLanguage
        /// to targetLanguage.
        /// </summary>
        /// <param name="tc">The TranslatorContainer to use</param>
        /// <param name="inputString">The string to translate</param>
        /// <param name="sourceLanguage">The Language Code to use in interpreting the input string.</param>
        /// <param name="targetLanguage">The Language Code to translate the input string to.</param>
        /// <returns>The translated string, or null if no translation results were found.</returns>
        private static Translation TranslateString(TranslatorContainer tc, string inputString, DetectedLanguage sourceLanguage, Language targetLanguage)
        {
            // Generate the query
            var translationQuery = tc.Translate(inputString, targetLanguage.Code, sourceLanguage.Code);

            // Call the query and get the results as a List
            var translationResults = translationQuery.Execute().ToList();

            // Verify there was a result
            if (translationResults.Count() <= 0)
            {
                return null;
            }

            // In case there were multiple results, pick the first one
            var translationResult = translationResults.First();

            return translationResult;
        }

        /// <summary>
        /// Concatenates the input arguments into a single string
        /// </summary>
        /// <param name="args">The args array passed into Main</param>
        /// <returns>the concatonated result string</returns>
        private static string GetInputString(string[] args)
        {
            // verify input and print usage instructions, if necessary.
            if (args.Length < 1)
            {
                return string.Empty;
            }

            // join the Command Line Arguments into a single string
            var inputString = string.Join(" ", args);

            return inputString;
        }
    }
}