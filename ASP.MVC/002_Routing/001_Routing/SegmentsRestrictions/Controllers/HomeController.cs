using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SegmentsRestrictions.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/About

        public ActionResult About()
        {
            return View("Index");
        }

        //
        // GET: /Home/Test

        public ActionResult Test()
        {
            return View("Index");
        }
    }
}
