using MerhabaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MerhabaAPI.Controllers.API
{
    public class ProductAPIModal
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
    }
    public class ProductsController : ApiController
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public IHttpActionResult GetProducts()
        {

            var ResList = from p in db.Products
                          select new
                          {
                              ProductNumber = p.ProductID,
                              //CategoryNumber = p.CategoryID,         iki farklı yol ikside aynı
                              //CategoryName=p.Categories.CategoryName
                              Category = p.CategoryID + "_" + p.Categories.CategoryName,
                              Price = p.UnitPrice,
                              QPU = p.QuantityPerUnit
                          };
            return Json(ResList.ToList());

        }
        public IHttpActionResult postProduct(string name, decimal price,int CategoryID)
        {
            try
            {
                Products p = new Products();
                p.ProductName = name;
                p.CategoryID = CategoryID;
                p.UnitPrice = price;
                db.Products.Add(p);
                db.SaveChanges();
                return StatusCode(HttpStatusCode.Created);
            }
            catch
            {
                return StatusCode(HttpStatusCode.BadRequest);
            }
        }
        [HttpPost]
        [Route("API/Product/add")]
        public string PostProduct(ProductAPIModal modal)
        {
            Products p = new Products()
            {
                CategoryID = modal.CategoryID,
                ProductName = modal.Name,
                UnitPrice = modal.Price
            };
            db.Products.Add(p);
            try
            { db.SaveChanges(); return "Başarılı"; } catch(Exception ex) { return ex.Message; }
        }
    }
}
