using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IgnoreRoteSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Не маршрутизировать любые запросы направленные к файлам с расширением axd и любой строкой параметров.
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // В данном проекте включена трассировка. Для того что бы получить информацию трассировки необходимо выполнить запрос
            // к виртуальному файлу trace.axd который находиться в корне приложения.
            // trace.axd - является точкой входа, зарегистрированной для HTTP обработчика.
            // Для включения трассировки используется элемент <trace enabled="true" /> в файле web.config

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}