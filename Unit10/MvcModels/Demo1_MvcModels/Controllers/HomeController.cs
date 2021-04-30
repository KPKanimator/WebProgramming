using Demo1_MvcModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1_MvcModels.Controllers
{
  public class HomeController : Controller
  {
    private List<User> UserCollection = new List<User> {
            new User {UserId = 0, FirstName = "Иван",
                LastName = "Иванов", Role = Role.Admin},
            new User {UserId = 1, FirstName = "Иван",
                LastName = "Иванов", Role = Role.Admin},
            new User {UserId = 2, FirstName = "Петр",
                LastName = "Петров", Role = Role.User},
            new User {UserId = 3, FirstName = "Сидор",
                LastName = "Сидоров", Role = Role.User},
            new User {UserId = 4, FirstName = "Вася",
                LastName = "Васильев", Role = Role.Guest}
        };
    // GET: Home
    public ActionResult Index(int id=1)
    {
      User user = UserCollection.Single(u => u.UserId == id);
      return View(user);
    }
    public ActionResult Test(int id = 1)
    {
      User user = UserCollection.Single(u => u.UserId == id);
      return View(user);
    }
  }
}