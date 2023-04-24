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
    public class ProjedetayYonetimiController : Controller
    {
        private DatabaseModel db = new DatabaseModel();

        // GET: Projedetays
        public ActionResult Index()
        {
            return View(db.Projedetay.ToList());
        }

        // GET: Projedetays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projedetay projedetay = db.Projedetay.Find(id);
            if (projedetay == null)
            {
                return HttpNotFound();
            }
            return View(projedetay);
        }

        // GET: Projedetays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projedetays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,resimyolu,kisabilgi,moduller,genelozellikler,teknikozellikler,baslik,sira")] Projedetay projedetay)
        {
            if (ModelState.IsValid)
            {
                db.Projedetay.Add(projedetay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projedetay);
        }

        // GET: Projedetays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projedetay projedetay = db.Projedetay.Find(id);
            if (projedetay == null)
            {
                return HttpNotFound();
            }
            return View(projedetay);
        }

        // POST: Projedetays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,resimyolu,kisabilgi,moduller,genelozellikler,teknikozellikler,baslik,sira")] Projedetay projedetay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projedetay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projedetay);
        }

        // GET: Projedetays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projedetay projedetay = db.Projedetay.Find(id);
            if (projedetay == null)
            {
                return HttpNotFound();
            }
            return View(projedetay);
        }

        // POST: Projedetays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projedetay projedetay = db.Projedetay.Find(id);
            db.Projedetay.Remove(projedetay);
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
