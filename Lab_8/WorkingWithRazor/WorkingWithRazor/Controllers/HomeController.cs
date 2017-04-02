using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingWithRazor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] names = { "Яблоко", "Апельсин", "Груша" };
            return View(names);
        }

        public ViewResult List()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Time()
        {
            return PartialView(DateTime.Now);
        }
    }

}