using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P01_ControllersAndActions.Controllers
{
  public class DerivedController : Controller
  {
    // GET: Derived
    public ActionResult Index()
    {
      ViewBag.Message = "Привет из контроллера DerivedController метода действия Index";
      return View();
    }
  }
}