using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerExtensibility.Infrastructure;

namespace ControllerExtensibility.Controllers
{
    public class ActionInvokerController : Controller
    {
        public ActionInvokerController()
        {
            this.ActionInvoker = new CustomActionInvoker();
        }
    }
}