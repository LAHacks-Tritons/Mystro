using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace WRole
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });

            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            app.UseTwitterAuthentication(
               consumerKey: "r9PUDf0SGUiFdPv7DGwQPZcwF",
               consumerSecret: "Gi6KJLmgSrTAWtcMFL0fKlxKdDH2QizMHJrTwM3prvjzoZquqC");

            app.UseFacebookAuthentication(
               appId: "636254263115501",
               appSecret: "dccdc9cd9654186e337f172541f9cfca");

            app.UseGoogleAuthentication("848644806707-3n8udgdlkm8fg1bh5d6j7v80jq4cruct.apps.googleusercontent.com", "6XuyxYDFzlIWphpmJvYU8Kad");
        }
    }
}