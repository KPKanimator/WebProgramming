using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperMethods.Models;


namespace HelperMethods.Controllers
{
    public class PeopleController : Controller
    {
        private List<User> UserData = new List<User> {
            new User {FirstName = "Тори", LastName = "Дородных", Role = Role.Admin},
            new User {FirstName = "Петр", LastName = "Петров", Role = Role.User},
            new User {FirstName = "Сидор", LastName = "Сидоров", Role = Role.User},
            new User {FirstName = "Вася", LastName = "Васильев", Role = Role.Guest}
        };

        public ActionResult Index()
        {
            return View();
        }

        public IEnumerable<User> GetData(string selectedRole)
        {
            IEnumerable<User> users = UserData;
            if (selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                users = UserData.Where(p => p.Role == selected);
            }
            return users;
        }

        public ActionResult GetPeopleData(string selectedRole = "All")
        {
            IEnumerable<User> users = GetData(selectedRole);
            if (selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                users = UserData.Where(p => p.Role == selected);
            }

            if (Request.IsAjaxRequest())
            {
                var formattedData = users.Select(p => new
                {
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Role = Enum.GetName(typeof(Role), p.Role)
                });
                return Json(formattedData, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return PartialView(users);
            }
        }

        public ActionResult GetPeople(string selectedRole = "All")
        {
            return View((Object)selectedRole);
        }

      }
}