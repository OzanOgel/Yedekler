using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warehouse.Admin
{
    public partial class AddOrder : System.Web.UI.Page
    {
        WarehouseDBEntities dm = new WarehouseDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            pnl_stock.Visible = false;
            ddl_Products.DataTextField = "name";
            ddl_Products.DataValueField = "ID";
            ddl_Products.DataSource = dm.Products.ToList();
            ddl_Products.DataBind();
            ddl_store.DataTextField = "StoreName";
            ddl_store.DataValueField = "ID";

            ddl_store.DataSource = dm.SupplierStore.ToList();
            ddl_store.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ProductID = Convert.ToInt32(ddl_Products.SelectedItem.Value);
            orders.StoreID = Convert.ToInt32(ddl_store.SelectedItem.Value);
            orders.total = Convert.ToInt32(tb_total.Text);
            int sayi = int.Parse(ddl_Products.SelectedItem.Value);
            var product = dm.Products.FirstOrDefault(p => p.ID == sayi);
            if(product.stock < Convert.ToInt32(tb_total.Text))
            {
                pnl_stock.Visible=true;

            }
            else
            {
                dm.Orders.Add(orders);
                dm.SaveChanges();   
            }
        }
    }
}