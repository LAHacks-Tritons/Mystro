using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WRole.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Title = "Home";


            return View();
        }

        public ActionResult IndexStudent()
        {

            ViewBag.Title = "Home";


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";


            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            ViewBag.Title = "Contact";

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}