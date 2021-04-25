using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_SegmentVariables.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        // Значения сегментов с именами x и y автоматически будут присвоены параметрам метода Index с теми же именами.
        // В случае, если значения, которые были получены из сегментов, не могут быть приведены к типу int, параметрам будет присвоено значение null, так как тип параметров int?,
        // в случае использования типа int произойдёт ошибка этапа выполнения.
        public ActionResult Index(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Result = x + y;
            }

            return View();
        }

    }
}
