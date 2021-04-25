using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _003_ActionFilter_Profile
{
    public class ProfileAttribute : FilterAttribute, IActionFilter
    {
        private Stopwatch sw;

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            sw = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            sw.Stop();
            if (filterContext.Exception == null)
            {
                string message = string.Format("На выполнение метода действия {0} затрачено {1}",
                    filterContext.ActionDescriptor.ActionName, sw.Elapsed);

                filterContext.HttpContext.Response.Write(message);
            }
        }
    }
}