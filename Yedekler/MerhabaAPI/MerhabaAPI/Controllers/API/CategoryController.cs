using MerhabaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MerhabaAPI.Controllers.API
{
   
    public class CategoryController : ApiController
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        public IHttpActionResult GetCategories()
        {
            var ResList = (from c in db.Categories
                           select new
                           {
                               ID = c.CategoryID,
                               Name = c.CategoryName,
                               Aciklama = c.Description
                           }).ToList();
            return Json(ResList.ToList());

        }

        public IHttpActionResult PostCategories(string Name,string Description)
        {
            try
            {
                Categories model = new Categories();
                model.CategoryName = Name;
                model.Description = Description;    
                db.Categories.Add(model);
                db.SaveChanges();
                return StatusCode(HttpStatusCode.Created);
            }
            catch 
            {
                return StatusCode(HttpStatusCode.BadRequest);
            }
        }
    }
}
