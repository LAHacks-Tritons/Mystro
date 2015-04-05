using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WRole.Models;

namespace WRole.Controllers
{
    public class StartController : Controller
    {
        //
        // GET: /Start/
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
               return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string Message, string Email, string Name)
        {
            if (ModelState.IsValid) {

         
                string host = "smtp.gmail.com";
                string user = "gasmart.ti@gmail.com";
                string password = "87octanos";

                var fromAddress = new MailAddress(user,"Newsteineducation.com");
                var toAddress = new MailAddress("contact@newsteineducation.com.lily.arvixe.com", "Newsteineducation.com");

                var smtp = new SmtpClient(host, 587)
                {
                    Credentials = new NetworkCredential(fromAddress.Address, password),
                    EnableSsl = true
                };

                try
                {
                    smtp.Send(user, "contact@newsteineducation.com.lily.arvixe.com", "Email from newteineducation.com contact", "Email: " + Email + "\nName: " +Name + "\nMessage: " + Message);
                }
                catch
                {
                }

                return RedirectToAction("MessageSent", "Start", new StartMessage() { Message =Message, Email=Email, Name=Name});
            }

            return View();
        }



        public ActionResult MessageSent(string Message,string Email, string Name)
        {

            return View();
        }


        public ActionResult ThankYou()
        {

            return View();
        }
	}
}