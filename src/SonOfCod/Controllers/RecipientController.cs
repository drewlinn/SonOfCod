using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SonOfCod.Models;
using System;


namespace SonOfCod.Controllers
{
    public class RecipientController : Controller
    {
        private SonOfCodContext db = new SonOfCodContext();
        public IActionResult Index()
        {
            return View(db.Recipients.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisRecipient = db.Recipients.FirstOrDefault(rec => rec.id == id);

            return View(thisRecipient);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Recipient recipient)
        {
            db.Recipients.Add(recipient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisRec = db.Recipients.FirstOrDefault(rec => rec.id == id);
            return View(thisRec);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisRec = db.Recipients.FirstOrDefault(rec => rec.id == id);
            db.Recipients.Remove(thisRec);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisRec = db.Recipients.FirstOrDefault(rec => rec.id == id);
            return View(thisRec);
        }
        [HttpPost]
        public IActionResult Edit(Recipient recipient)
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