using MvcKullaniyorum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKullaniyorum.Controllers
{
    public class AnasayfaController : Controller
    {
        NORTHWNDEntities dm = new NORTHWNDEntities();
        // GET: Anasayfa
        public ActionResult Index()
        {
            
            return View();
        }
    }
}