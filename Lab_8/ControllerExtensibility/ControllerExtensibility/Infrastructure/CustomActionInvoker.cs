using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerExtensibility.Infrastructure
{
    public class CustomActionInvoker : IActionInvoker
    {
        public bool InvokeAction(ControllerContext controllerContext,
                string actionName)
        {
            if (actionName == "Index")
            {
                controllerContext.HttpContext.
                    Response.Write("Это вывод данных из метода действия Index");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
