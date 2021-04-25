using SpecialTemplateSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpecialTemplateSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Person person = new Person();
            person.PersonId = 1;
            person.Name = "Jhon Doe";
            person.Role = Role.User;

            return View(person);
        }

    }
}
