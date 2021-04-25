using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace _002_ActionFilterSample
{
    // Атрибут, который реализует интерфейс IActionFilter, используется для декорирования действий в контроллере.
    public class MyActionFilterAttribute : FilterAttribute, IActionFilter
    {
        // Метод запускается до выполнения кода действия.
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Проверка наличия значения в cookies
            if (filterContext.HttpContext.Request.Cookies["test"] != null)
            {
                // Метод действия не выполняется, если в свойство Result записать значение отличное от null.
                filterContext.Result = new HttpNotFoundResult();
            }
        }

        // Метод запускается после выполнения кода действия.
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }
    }
}
