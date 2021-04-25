using CSRF_NotVulnerableSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace CSRF_NotVulnerableSite.Controllers
{
    [Authorize] // Контроллер не позволяет анонимным пользователям выполнять операции
    public class PersonalController : Controller
    {
        //
        // GET: /Personal/

        public ActionResult Index()
        {
            string homePage = null;
            using (UsersContext context = new UsersContext())
            {
                homePage = context.UserProfiles.Single(x => x.UserId == WebSecurity.CurrentUserId).HomePage;
            }
            return View((object)homePage ?? "-----");
        }

        //
        // GET: /Personal/EditPersonalPage

        public ActionResult EditPersonalPage()
        {
            return View();
        }

        [ValidateAntiForgeryToken] // фильтр проверяет, что с клиента пришла форма содержащая поле и cookie набор с именем __RequestVerificationToken и соответствующими значениями
        [HttpPost]
        public ActionResult EditPersonalPage(string personalPage)
        {
            using (UsersContext context = new UsersContext())
            {
                // Поиск записи текущего пользователя в базе и смена его адреса персональной страницы
                var user = context.UserProfiles.Single(x => x.UserId == WebSecurity.CurrentUserId);
                user.HomePage = personalPage;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}

