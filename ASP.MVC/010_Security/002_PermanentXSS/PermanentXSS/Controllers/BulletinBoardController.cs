using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PermanentXSS.Models;
using Microsoft.Security.Application;

namespace PermanentXSS.Controllers
{
    public class BulletinBoardController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /BulletinBoard/

        public ActionResult Index()
        {
            return View(db.BulletinBoardItems.ToList());
        }

        //
        // GET: /BulletinBoard/Details/5

        public ActionResult Details(int id = 0)
        {
            BulletinBoardItem bulletinboarditem = db.BulletinBoardItems.Find(id);
            if (bulletinboarditem == null)
            {
                return HttpNotFound();
            }
            return View(bulletinboarditem);
        }

        //
        // GET: /BulletinBoard/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BulletinBoard/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)] // отключение валидации данных полученных от клиента.
        public ActionResult Create(BulletinBoardItem bulletinboarditem)
        {
            if (ModelState.IsValid)
            {
                // Проверка данных с помощью библиотеки AntiXSS
                // Для установки библиотеки через Package Manager Console исопльзуется команда  Install-Package AntiXSS

                // Убрать комментарий для включения проверки CSS
                //bulletinboarditem.Title = Sanitizer.GetSafeHtmlFragment(bulletinboarditem.Title);
                //bulletinboarditem.Message = Sanitizer.GetSafeHtmlFragment(bulletinboarditem.Message);

                db.BulletinBoardItems.Add(bulletinboarditem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bulletinboarditem);
        }

        //
        // GET: /BulletinBoard/Edit/5
        
        public ActionResult Edit(int id = 0)
        {
            BulletinBoardItem bulletinboarditem = db.BulletinBoardItems.Find(id);
            if (bulletinboarditem == null)
            {
                return HttpNotFound();
            }
            return View(bulletinboarditem);
        }

        //
        // POST: /BulletinBoard/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit(BulletinBoardItem bulletinboarditem)
        {
            if (ModelState.IsValid)
            {
                // Проверка данных с помощью библиотеки AntiXSS
                //bulletinboarditem.Title = Sanitizer.GetSafeHtmlFragment(bulletinboarditem.Title);
                //bulletinboarditem.Message = Sanitizer.GetSafeHtmlFragment(bulletinboarditem.Message);

                db.Entry(bulletinboarditem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bulletinboarditem);
        }

        //
        // GET: /BulletinBoard/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BulletinBoardItem bulletinboarditem = db.BulletinBoardItems.Find(id);
            if (bulletinboarditem == null)
            {
                return HttpNotFound();
            }
            return View(bulletinboarditem);
        }

        //
        // POST: /BulletinBoard/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BulletinBoardItem bulletinboarditem = db.BulletinBoardItems.Find(id);
            db.BulletinBoardItems.Remove(bulletinboarditem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}