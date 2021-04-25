using EditorForModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EditorForModel.Controllers
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
