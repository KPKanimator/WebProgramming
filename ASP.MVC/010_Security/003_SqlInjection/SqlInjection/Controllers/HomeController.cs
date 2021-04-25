using SqlInjection.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SqlInjection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AuthFormBad()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AuthFormBad(string login, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT Login FROM Users WHERE Login='{0}' AND Password='{1}'", login, password);
                // в случае если пользователь передаст в качестве значения login значение x' OR 1=1 -- , а пароль пустым
                // будет сформирован следующий SQL запрос - SELECT * FROM Users WHERE Login='x' OR 1=1 -- AND Password=''
                // Такой запрос выберет все записи из таблицы Users так как значение 1 всегда равно 1 даже если пользователя с именем x не будет в базе
                // -- комментарии, соответственно пароль проверяться не будет.

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object userLogin = command.ExecuteScalar();
                if (userLogin != null)
                {
                    return View("Completed", userLogin);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Логин или пароль введены не правильно");
                }
            }

            return View();
        }

        public ActionResult AuthFormGood()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AuthFormGood(string login, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Login FROM Users WHERE Login=@Login AND Password=@Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Login", login);
                command.Parameters.AddWithValue("Password", password);

                connection.Open();
                object userLogin = command.ExecuteScalar();
                if (userLogin != null)
                {
                    return View("Completed", userLogin);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Логин или пароль введены не правильно");
                }
            }
            return View();
        }

        public ActionResult AuthFormGoodEF()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AuthFormGoodEF(string login, string password)
        {
            using (UserContext context = new UserContext())
            {
                bool isUserExists = context.Users.Any(x => x.Login == login && x.Password == password);
                if (isUserExists)
                {
                    return View("Completed", login);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Логин или пароль введены не правильно");
                }
            }
            return View();
        }

    }
}
