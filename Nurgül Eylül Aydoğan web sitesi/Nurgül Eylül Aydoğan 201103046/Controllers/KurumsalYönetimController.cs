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
    public class KurumsalYönetimController : Controller
    {
        private DatabaseModel db = new DatabaseModel();

        // GET: KurumsalYönetim
        public ActionResult Index()
        {
            return View(db.Kurumsal.ToList());
        }

        // GET: KurumsalYönetim/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kurumsal kurumsal = db.Kurumsal.Find(id);
            if (kurumsal == null)
            {
                return HttpNotFound();
            }
            return View(kurumsal);
        }

        // GET: KurumsalYönetim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KurumsalYönetim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,baslik,icerik")] Kurumsal kurumsal)
        {
            if (ModelState.IsValid)
            {
                db.Kurumsal.Add(kurumsal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kurumsal);
        }

        // GET: KurumsalYönetim/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kurumsal kurumsal = db.Kurumsal.Find(id);
            if (kurumsal == null)
            {
                return HttpNotFound();
            }
            return View(kurumsal);
        }

        // POST: KurumsalYönetim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,baslik,icerik")] Kurumsal kurumsal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kurumsal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kurumsal);
        }

        // GET: KurumsalYönetim/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kurumsal kurumsal = db.Kurumsal.Find(id);
            if (kurumsal == null)
            {
                return HttpNotFound();
            }
            return View(kurumsal);
        }

        // POST: KurumsalYönetim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kurumsal kurumsal = db.Kurumsal.Find(id);
            db.Kurumsal.Remove(kurumsal);
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
