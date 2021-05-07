using System.Web.Mvc;
using System.Web.Security;

namespace FilterWebApplication.Controllers
{
  public class GoogleAccountController : Controller
  {
    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Login(string username, string password, string returnUrl)
    {
      if (username.EndsWith("@google.com") && password == "12345")
      {
        FormsAuthentication.SetAuthCookie(username, false);
        return Redirect(returnUrl ?? Url.Action("Index", "Home"));
      }
      else
      {
        ModelState.AddModelError("", "Некорректное имя пользователя или пароль");
        return View();
      }
    }

  }
}