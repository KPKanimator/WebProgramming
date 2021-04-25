using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilters.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        // Для работы фильтра HandleError в файле web.config нужно добавить <customErrors mode="On"></customErrors>
        // В случае возникновения исключения типа DivideByZeroException будет возвращено представление DivideError
        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideError")]
        public ActionResult Divide()
        {
            int a = 10, b = 0;
            int result = a / b;

            return Content(result.ToString());
        }

    }
}
