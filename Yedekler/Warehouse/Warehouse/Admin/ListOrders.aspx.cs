using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warehouse.Admin
{
    public partial class ListOrders : System.Web.UI.Page
    {
        WarehouseDBEntities dm = new WarehouseDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_Orders.DataSource = dm.Orders.ToList();
            lv_Orders.DataBind();
        }

        protected void lv_Orders_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "remove")
            {
               
                var silinecekNesneler = dm.Orders.Where(n => n.ID == id);
                dm.Orders.RemoveRange(silinecekNesneler);
                dm.SaveChanges();
            }
            lv_Orders.DataSource = dm.Orders.ToList();
            lv_Orders.DataBind();
        }
    }
}