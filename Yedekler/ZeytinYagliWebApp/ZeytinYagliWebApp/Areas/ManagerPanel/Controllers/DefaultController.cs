using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeytinYagliWebApp.Areas.ManagerPanel.Filter;

namespace ZeytinYagliWebApp.Areas.ManagerPanel.Controllers
{
    [ManagerLoginFilter]
    public class DefaultController : Controller
    {
        // GET: ManagerPanel/Default
        
        public ActionResult Index()
        {
            return View();
        }
    }
}