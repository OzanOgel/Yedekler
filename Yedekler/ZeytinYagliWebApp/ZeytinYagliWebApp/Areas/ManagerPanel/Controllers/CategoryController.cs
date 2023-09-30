using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeytinYagliWebApp.Areas.ManagerPanel.Filter;
using ZeytinYagliWebApp.Models;

namespace ZeytinYagliWebApp.Areas.ManagerPanel.Controllers
{
    //[ManagerLoginFilter]
    public class CategoryController : Controller
    {
        OliveOilDBModel db = new OliveOilDBModel();
        // GET: ManagerPanel/Category
        public ActionResult Index()
        {
            return View(db.Categories.Where(x => x.IsDeleted == false).ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int? id) //nullable integer
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            Category c = db.Categories.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }
        public ActionResult Edit(Category model)
        {
        if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        return View(model);
        }
    }
}