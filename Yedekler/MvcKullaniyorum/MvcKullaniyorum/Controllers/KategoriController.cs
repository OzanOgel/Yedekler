using MvcKullaniyorum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKullaniyorum.Controllers
{
    public class KategoriController : Controller
    {
        NORTHWNDEntities dm = new NORTHWNDEntities();
        // GET: Kategori
        //Genelde Listeleme İşlemleri için Index Kullanılır 
        public ActionResult Index()
        {
            return View(dm.Categories.ToList());
        }
        [HttpGet]
        public ActionResult ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ekle(string isim,string aciklama) {
            Categories c = new Categories();
            c.CategoryName = isim;
            c.Description = aciklama;
           dm.Categories.Add(c);
            dm.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult create() { 
            return View();
        }
       

        
    }
}