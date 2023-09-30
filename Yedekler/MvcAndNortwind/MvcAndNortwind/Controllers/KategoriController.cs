using MvcAndNortwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAndNortwind.Controllers
{
    public class KategoriController : Controller
    {
       NORTHWNDEntities dm = new NORTHWNDEntities();
        // GET: Kategori
        public ActionResult Index()
        {
            return View(dm.Categories.ToList());
        }
    }
}