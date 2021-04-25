using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OptionalSegments.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //public ActionResult Index(int id = 1) // int id = 1 в случае если значение будет отсутствовать в сегментах, будет использовано значение 1
        public ActionResult Index(string id)
        {
            ViewBag.Variable = id;
            return View();
        }

    }
}
