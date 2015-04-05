using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WRole.Controllers
{
    public class FormsController : Controller
    {
        //
        // GET: /Forms/
        public ActionResult Index()
        {
            return View("Elements",null);
        }

        //
        // GET: /Forms/Elements
        public ActionResult Elements()
        {
            return View();
        }

        //
        // GET: /Forms/Layouts
        public ActionResult Layouts()
        {
            return View();
        }

        //
        // GET: /Forms/Validation
        public ActionResult Validation()
        {
            return View();
        }

        //
        // GET: /Forms/Wizard
        public ActionResult Wizard()
        {
            return View();
        }
	}
}