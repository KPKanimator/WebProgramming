using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace _003_ActionFilter_Profile.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [Profile]
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

    }
}
