using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WRole.Controllers
{
    public class TablesController : Controller
    {
        //
        // GET: /Tables/
        public ActionResult Index()
        {
            return View("Dynamic",null);
        }

        //
        // GET: /Tables/Dynamic
        public ActionResult Dynamic()
        {
            return View();
        }

        //
        // GET: /Tables/Responsive
        public ActionResult Responsive()
        {
            return View();
        }

        //
        // GET: /Tables/Static
        public ActionResult Static()
        {
            return View();
        }
	}
}