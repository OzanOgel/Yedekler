using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeytinYagliWebApp.Areas.ManagerPanel.modal;
using ZeytinYagliWebApp.Models;

namespace ZeytinYagliWebApp.Areas.ManagerPanel.Controllers
{
    public class LoginController : Controller
    {
        // GET: ManagerPanel/Login
        OliveOilDBModel dm = new OliveOilDBModel();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ManagerLoginViewModel model)
        {
           if (ModelState.IsValid)
            {
                int count = dm.Managers.Count(x => x.Mail == model.Mail && x.Password == model.Password);
                if (count > 0)
                {
                    Manager m = dm.Managers.First(x => x.Mail == model.Mail && x.Password == model.Password);
                    if(m.IsActive)
                    {
                        Session["manager"] = 0;
                        return RedirectToAction("Index","Default");
                    }
                    else
                    {
                        TempData["mesaj"] = "Hesabınız askıya alınmıştır";
                    }

                }
                else
                {
                    TempData["mesaj"] = "Kullanıcı Bulunamadı";
                }
            }
           return View(model);
        }

    }
}