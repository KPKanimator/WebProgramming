using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcIntroduction.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        // Для запуска данного метода следует сделать запрос по адресу 
        // 'http://localhost:port/Home/Index' или 'http://localhost:port/Home/'
        // Также данный метод будет запущен при выполнении запроса 'http://localhost:port/', так как путь /Home/Index
        // настроен как путь по умолчанию в файле /App_Start/RouteConfig.cs

        public ActionResult Index()
        {
            return View();
        }

    }
}
