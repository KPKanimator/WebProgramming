using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _002_ActionFilterSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        // Атрибут не дает запустить метод действия и возвращает ошибку 404 
        // если в cookie наборах запроса нет записи с именем test
        [MyActionFilter]
        public ActionResult Index()
        {
            return View();
        }

    }
}
