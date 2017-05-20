using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperMethods.Models;


namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] { "Яблоко", "Апельсин", "Груша" };
            ViewBag.Cities = new string[] { "Москва", "Лондон", "Париж" };

            string message = "Это HTML-элемент: <input>";

            return View((object)message);
        }
        public ActionResult CreateUser()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult CreateUser(User User)
        {
            return View("DisplayUser", User);
        }
	}
}