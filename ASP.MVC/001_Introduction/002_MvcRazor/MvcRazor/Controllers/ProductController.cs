using MvcRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRazor.Controllers
{
    public class ProductController : Controller
    {

        //
        // GET: /Product/

        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                ProductId = 1,
                Name = "Шариковая ручка",
                Description = "Синяя шариковая ручка с колпачком и прозрачным корпусом.",
                Price = 3m,
                Category = "Канцтовары"
            });

            products.Add(new Product()
            {
                ProductId = 2,
                Name = "Бумага A4",
                Description = "Стандартная бумага для цветной и чёрно-белой печати.",
                Price = 15m,
                Category = "Канцтовары"
            });

            products.Add(new Product()
            {
                ProductId = 2,
                Name = "Мобильный телефон",
                Description = "Мобильный телефон с фотокамерой.",
                Price = 250m,
                Category = "Техника"
            });

            // Возвращаем представление из директории Views/Products/Index.cshtml
            // Параметр передающийся в метод View() является моделью, которая будет доступна только на чтение в представлении Index
            return View(products);
        }

    }
}
