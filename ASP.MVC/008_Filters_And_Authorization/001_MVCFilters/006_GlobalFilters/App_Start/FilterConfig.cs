using System.Web;
using System.Web.Mvc;

namespace _006_GlobalFilters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()); // Глобальный системный фильтр для обработки исключений
            filters.Add(new SimpleMessageAttribute("GLOBAL")); // Глобальный пользовательский фильтр
        }
    }
}