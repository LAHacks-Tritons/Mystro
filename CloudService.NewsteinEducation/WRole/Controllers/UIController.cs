using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WRole.Controllers
{
    public class UIController : Controller
    {
        //
        // GET: /UI/
        public ActionResult Index()
        {
            return View("Widgets",null);
        }

        //
        // GET: /UI/Buttons
        public ActionResult Buttons()
        {
            return View();
        }

        //
        // GET: /UI/Components
        public ActionResult Components()
        {
            return View();
        }

        //
        // GET: /UI/Grids
        public ActionResult Grids()
        {
            return View();
        }

        //
        // GET: /UI/Icons
        public ActionResult Icons()
        {
            return View();
        }

        //
        // GET: /UI/Typography
        public ActionResult Typography()
        {
            return View();
        }

        //
        // GET: /UI/Widgets
        public ActionResult Widgets()
        {
            return View();
        }
	}
}