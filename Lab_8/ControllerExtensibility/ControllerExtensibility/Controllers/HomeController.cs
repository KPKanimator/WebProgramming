using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerExtensibility.Infrastructure;
using ControllerExtensibility.Models;


namespace ControllerExtensibility.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Home",
                ActionName = "Index"
            });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result
            {
                ControllerName = "Home",
                ActionName = "LocalIndex"
            });
        }

        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write(string.Format("Вы запросили метод действия <b>{0}</b>", actionName));
        }
    }
}