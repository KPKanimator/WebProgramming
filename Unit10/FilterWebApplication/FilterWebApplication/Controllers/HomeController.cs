using FilterWebApplication.Infrastructure;
using System.Web.Mvc;

namespace FilterWebApplication.Controllers
{
  public class HomeController : Controller
  {
    [GoogleAuth]
    [Authorize(Users = "kir@google.com")]
    public string List()
    {
      return "Это метод действия List в контроллере Home";
    }

    //[CustomAuth(true)]
    [Authorize(Users = "admin")]
    public string Index()
    {
      return "Это метод действия Index в контроллере Home";
    }
  }
}