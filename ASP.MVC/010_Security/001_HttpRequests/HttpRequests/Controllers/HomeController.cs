using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpRequests.Controllers
{
    public class HomeController : Controller
    {
        // Получение страницы администратора или обычного пользователя.
        // GET: /Home/

        public ActionResult Index()
        {
            HttpCookie adminCookies = Request.Cookies["IsAdmin"];
            if (adminCookies != null)
            {
                if (adminCookies.Value.ToLower() == "true")
                {
                    return View("AdminIndex");
                }
                else
                {
                    return View("UserIndex");
                }
            }
            return View();
        }

        // Получение страницы авторизации.
        // GET: /Home/Login

        public ActionResult Login()
        {
            return View();
        }

        // Проверка правильности логина и пароля.
        // POST: /Home/Login

        [HttpPost]
        public ActionResult Login(string login, string password)
        {
            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError(string.Empty, "Вы не ввели логин или пароль");
                return View();
            }

            if (login.ToLower() == "admin" && password == "qwerty")
            {
                HttpCookie adminCookie = new HttpCookie("IsAdmin", "true");
                Response.Cookies.Add(adminCookie);
                return RedirectToAction("Index");
            }
            else if (login.ToLower() == "user" && password == "12345")
            {
                HttpCookie adminCookie = new HttpCookie("IsAdmin", "false");
                Response.Cookies.Add(adminCookie);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Не правильно введенный логин или праоль");
                return View();
            }
        }

    }
}
