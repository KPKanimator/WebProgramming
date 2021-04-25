using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SegmentsRestrictions
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Маршрут настроен таким образом, что для совпадения с входящим запросам, значения переменных сегментов
            // должны подходить под шаблон, который задан через регулярное выражение.
            // Данный маршрут требует, что бы переменная {controller} имела значение, которое начинается с символа H,
            // {action} должна иметь значение либо Index либо About, переменная {id} должна быть числовым значением.

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { controller = "^H.*", action = "^Index$|^About$", id = "^\\d*$" } 
            );
        }
    }
}