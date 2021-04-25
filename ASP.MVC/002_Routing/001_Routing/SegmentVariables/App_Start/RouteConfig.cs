using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SegmentVariables
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = "DefaultId" }
            );

            // !!!!!!
            // Некторые имена зарезервированы и не могут использоваться как имена для переменных сегментов.
            // К таким именам относятся controller, action и area
        }
    }
}