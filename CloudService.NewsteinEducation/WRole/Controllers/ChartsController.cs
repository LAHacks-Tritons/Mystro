using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WRole.Controllers
{
    public class ChartsController : Controller
    {
        //
        // GET: /Charts/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Charts/Flot
        public ActionResult Flot()
        {
            return View();
        }

        //
        // GET: /Charts/Morris
        public ActionResult Morris()
        {
            return View();
        }
	}
}