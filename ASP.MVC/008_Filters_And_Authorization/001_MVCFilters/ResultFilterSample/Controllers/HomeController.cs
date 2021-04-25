using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ResultFilterSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [Profile]
        public ActionResult SlowAction()
        {
            Thread.Sleep(2000);
            return View();
        }

        [Profile]
        public ActionResult SlowView()
        {
            return View();
        }

    }
}
