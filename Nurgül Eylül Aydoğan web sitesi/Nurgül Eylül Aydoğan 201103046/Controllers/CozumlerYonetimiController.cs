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
    public class CozumlerYonetimiController : Controller
    {
        private DatabaseModel db = new DatabaseModel();

        // GET: CozumlerYonetimi
        public ActionResult Index()
        {
            return View(db.Cozumler.ToList());
        }

        // GET: CozumlerYonetimi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cozumler cozumler = db.Cozumler.Find(id);
            if (cozumler == null)
            {
                return HttpNotFound();
            }
            return View(cozumler);
        }

        // GET: CozumlerYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CozumlerYonetimi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,resimyolu,bilgi,sira,baslik")] Cozumler cozumler)
        {
            if (ModelState.IsValid)
            {
                db.Cozumler.Add(cozumler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cozumler);
        }

        // GET: CozumlerYonetimi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cozumler cozumler = db.Cozumler.Find(id);
            if (cozumler == null)
            {
                return HttpNotFound();
            }
            return View(cozumler);
        }

        // POST: CozumlerYonetimi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,resimyolu,bilgi,sira,baslik")] Cozumler cozumler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cozumler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cozumler);
        }

        // GET: CozumlerYonetimi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cozumler cozumler = db.Cozumler.Find(id);
            if (cozumler == null)
            {
                return HttpNotFound();
            }
            return View(cozumler);
        }

        // POST: CozumlerYonetimi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cozumler cozumler = db.Cozumler.Find(id);
            db.Cozumler.Remove(cozumler);
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
