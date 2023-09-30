using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warehouse.Admin
{
    public partial class listStore : System.Web.UI.Page
    {
        WarehouseDBEntities dm = new WarehouseDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_store.DataSource = dm.SupplierStore.ToList();
            lv_store.DataBind();
        }

        protected void lv_store_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "remove")
            {

                var silinecekNesneler = dm.SupplierStore.Where(n => n.ID == id);
                dm.SupplierStore.RemoveRange(silinecekNesneler);
                dm.SaveChanges();

            }
            lv_store.DataSource = dm.SupplierStore.ToList();
            lv_store.DataBind();

        }
    }
}