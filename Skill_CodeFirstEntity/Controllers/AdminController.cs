using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.Siniflar;

namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            
            var degerler = c.Yeteneks.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(Yetenek y)
        {
            c.Yeteneks.Add(y);
            c.SaveChanges();
            return View();
        }

        public ActionResult YetenekSil(int id)
        {
            var deger = c.Yeteneks.Find(id);
            c.Yeteneks.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var deger = c.Yeteneks.Find(id);
            return View("YetenekGetir",deger);

        }

        [HttpPost]
        public ActionResult YetenekGetir(Yetenek y)
        {
            var x=c.Yeteneks.Find(y.ID);
            x.Aciklama = y.Aciklama;
            x.Deger = y.Deger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}