using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _007_OutputCache.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        // OutputCache – указывает, что ответ нужно кэшировать на время указанное в параметре Duration
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            ViewBag.Message = "Операция выполнена в " + DateTime.Now.ToLongTimeString();
            return View();
        }

    }
}
