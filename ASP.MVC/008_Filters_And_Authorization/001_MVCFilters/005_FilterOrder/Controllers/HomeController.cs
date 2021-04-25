using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _005_FilterOrder.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [SimpleMessage(Message = "A", Order = 2)]
        [SimpleMessage(Message = "B", Order = 1)]
        public ActionResult Index()
        {
            return View();
        }

    }
}
