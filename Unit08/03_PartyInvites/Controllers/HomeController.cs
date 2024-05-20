using _03_PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_PartyInvites.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
      return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guest)
    {
      if (ModelState.IsValid)
        // Нужно отправить данные нового гостя по электронной почте 
        // организатору вечеринки.
        return View("Thanks", guest);
      else
        // Обнаружена ошибка проверки достоверности
        return View();
    }

  }
}