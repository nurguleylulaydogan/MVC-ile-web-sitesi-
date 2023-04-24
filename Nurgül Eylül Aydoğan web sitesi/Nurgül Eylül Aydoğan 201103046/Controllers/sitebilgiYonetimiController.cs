using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nurgül_Eylül_Aydoğan_201103046.DAL;

namespace Nurgül_Eylül_Aydoğan_201103046.Controllers
{
    public class sitebilgiYonetimiController : Controller
    {
        private DatabaseModel db = new DatabaseModel();

        // GET: sitebilgiYonetimi
        public ActionResult Index()
        {
            return View(db.sitebilgi.ToList());
        }

        // GET: sitebilgiYonetimi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sitebilgi sitebilgi = db.sitebilgi.Find(id);
            if (sitebilgi == null)
            {
                return HttpNotFound();
            }
            return View(sitebilgi);
        }

        // GET: sitebilgiYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: sitebilgiYonetimi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,firmaadi,logoyolu,kucuklogoyolu,telefon,email,adres,harita")] sitebilgi sitebilgi)
        {
            if (ModelState.IsValid)
            {
                db.sitebilgi.Add(sitebilgi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sitebilgi);
        }

        // GET: sitebilgiYonetimi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sitebilgi sitebilgi = db.sitebilgi.Find(id);
            if (sitebilgi == null)
            {
                return HttpNotFound();
            }
            return View(sitebilgi);
        }

        // POST: sitebilgiYonetimi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,firmaadi,logoyolu,kucuklogoyolu,telefon,email,adres,harita")] sitebilgi sitebilgi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sitebilgi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sitebilgi);
        }

        // GET: sitebilgiYonetimi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sitebilgi sitebilgi = db.sitebilgi.Find(id);
            if (sitebilgi == null)
            {
                return HttpNotFound();
            }
            return View(sitebilgi);
        }

        // POST: sitebilgiYonetimi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sitebilgi sitebilgi = db.sitebilgi.Find(id);
            db.sitebilgi.Remove(sitebilgi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
