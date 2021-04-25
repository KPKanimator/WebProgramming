using ModelsMetadata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsMetadata.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Customer customer = new Customer() 
            {
                Id = 1,
                FirstName = "Ivan", 
                LastName ="Ivanov",
                IsApproved = true,
                Description = "text... text... text...",
                RegistrationDate = DateTime.Now,
                Foo = 123
            };

            return View(customer);
        }

    }
}
