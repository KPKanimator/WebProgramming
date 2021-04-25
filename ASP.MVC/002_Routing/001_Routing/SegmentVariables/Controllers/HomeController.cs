using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SegmentVariables.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            // RouteData.Values - коллекция значений сегментов, доступных в момент обработки текущего запроса
            // ViewBag - динамический словарь, который позволяет передавать данные в представление
            ViewBag.Variable = RouteData.Values["id"];
            return View();
        }

        //
        // GET: /CustomVariable/

        // Отображение переменной id на параметр метода доступа.
        // MVC Framework будет пытаться преобразовать значение, полученное из URL, в тип указанный в параметрах.
        public ActionResult CustomVariable(int? id) 
        {
            ViewBag.Variable = id;

            // Метод действия CustomVariable по умолчанию должен возвращать представление CustomVariable.cshtml из директории Views/Home
            // Строковое значение, переданное в качестве параметра метода View, позволяет задать другое представление, которое вернется в ответ на запрос
            return View("Index");
        }

    }
}
