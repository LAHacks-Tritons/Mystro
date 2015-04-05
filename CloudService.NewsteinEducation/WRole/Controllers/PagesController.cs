using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WRole.Controllers
{

    [Authorize()]
    public class PagesController : Controller
    {
        //
        // GET: /Pages/
        public ActionResult Index()
        {
            return View("Profile",null);
        }

        //
        // GET: /Pages/Profile
        public ActionResult  Prof ()
        {
            return View();
        }

        //
        // GET: /Pages/404
        public ActionResult Error404()
        {
            return View();
        }

        //
        // GET: /Pages/500
        public ActionResult Error500()
        {
            return View();
        }

        //
        // GET: /Pages/Features
        public ActionResult Features()
        {
            return View();
        }

        //
        // GET: /Pages/Signin
        public ActionResult Signin()
        {
            return View();
        }

        //
        // GET: /Pages/Signup
        public ActionResult Signup()
        {
            return View();
        }
	}
}