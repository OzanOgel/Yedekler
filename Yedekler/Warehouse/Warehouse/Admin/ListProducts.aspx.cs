using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warehouse.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WarehouseDBEntities dm = new WarehouseDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<Products> products = dm.Products.ToList();
            lv_Products.DataSource = products;
            lv_Products.DataBind();
            
        }

        protected void lv_Products_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
           
            int id = Convert.ToInt32(e.CommandArgument);
           
            if (e.CommandName == "remove")
            {
                var orders = dm.Orders.Where(o => o.ProductID == id);
                dm.Orders.RemoveRange(orders);
                dm.SaveChanges();
                var silinecekNesneler = dm.Products.Where(n => n.ID == id);
                dm.Products.RemoveRange(silinecekNesneler);
                dm.SaveChanges();
            }
            List<Products> products = dm.Products.ToList();
            lv_Products.DataSource=products;
            lv_Products.DataBind();
           
            

        }
    }
}