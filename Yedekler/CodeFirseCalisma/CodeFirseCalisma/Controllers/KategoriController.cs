using CodeFirseCalisma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirseCalisma.Controllers
{
    public class KategoriController : Controller
    {
        CodeFirstDB dm = new CodeFirstDB();
        // GET: Kategori
        public ActionResult Index()
        {
            List<Kategoriler> Kategorilist = dm.Kategorilers.ToList();


            return View(Kategorilist);
        }

        public ActionResult KategoriEkle()
        {
            return View();
        }
    }
}