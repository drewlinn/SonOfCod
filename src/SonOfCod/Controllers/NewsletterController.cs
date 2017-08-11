using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SonOfCod.Models;
using System;

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        private SonOfCodContext db = new SonOfCodContext();
        public IActionResult Index()
        {
            return View(db.Newsletters.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisNewsletter = db.Newsletters.FirstOrDefault(rec => rec.id == id);

            return View(thisNewsletter);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Newsletter recipient)
        {
            db.Newsletters.Add(recipient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisNL = db.Newsletters.FirstOrDefault(nl => nl.id == id);
            return View(thisNL);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisNL = db.Newsletters.FirstOrDefault(nl => nl.id == id);
            db.Newsletters.Remove(thisNL);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisNL = db.Newsletters.FirstOrDefault(nl => nl.id == id);
            return View(thisNL);
        }
        [HttpPost]
        public IActionResult Edit(Newsletter recipient)
        {
            db.Entry(recipient).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
