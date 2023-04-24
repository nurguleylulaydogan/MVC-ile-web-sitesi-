using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nurgül_Eylül_Aydoğan_201103046.DAL;

namespace Nurgül_Eylül_Aydoğan_201103046.Controllers
{
    public class HomeController : Controller
    {
        DatabaseModel db = new DatabaseModel();
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Iletisim()
        {
            var siteBilgileri = db.sitebilgi.FirstOrDefault();

            return View(siteBilgileri);
        }
        public ActionResult Kurumsal(string id)
        {
            var kurumsal = db.Kurumsal.Where(h => h.baslik == id).FirstOrDefault();
            if (kurumsal == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Kurumsal = db.Kurumsal.ToList();
            

            return View(kurumsal);
        }



        public ActionResult Cozumlerimiz()
        {
            var cozumlerimiz = db.Cozumler.OrderBy(h => h.sira).ToList();

            return View(cozumlerimiz);
        }

        public ActionResult Detay(int id)
        {
            var detaylar = db.Projedetay.Where(h => h.id == id).FirstOrDefault();
            if (detaylar == null)
            {
                return RedirectToAction("Index");
            }
            return View(detaylar);

        }


    }
}