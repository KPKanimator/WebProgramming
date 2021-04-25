using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_DataFromContextObjects.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            // Свойства контроллера для доступа к информации о запросе.
            // Request - данные о текущем HTTP запросе.
            // Response - данные о текущем HTTP ответе.
            // RouteData - данные маршрутизации для текущего запроса.
            // HttpContext - получение специфической информации о текущем HTTP запросе.
            // Server - объект с методами для обработки HTTP запроса.

            string userName = User.Identity.Name;
            string machineName = Server.MachineName;
            string clientIp = Request.UserHostAddress;

            string formData = Request.Form["data"];
            string queryStringData = Request.QueryString["data"];
            HttpCookie cookie = Request.Cookies["cookieName"];

            return View();
        }

    }
}
