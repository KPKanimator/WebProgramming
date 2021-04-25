using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplatedHelperMethods.Models;

namespace TemplatedHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Product p = new Product()
            {
                Id = 1,
                Name = "Test Product",
                IsTangible = false
            };
            return View(p);
        }

    }
}
