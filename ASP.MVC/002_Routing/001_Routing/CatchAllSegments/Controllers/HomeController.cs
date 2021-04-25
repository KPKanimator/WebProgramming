using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatchAllSegments.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Id = RouteData.Values["Id"];
            ViewBag.All = RouteData.Values["catchall"];
            return View();
        }

    }
}
