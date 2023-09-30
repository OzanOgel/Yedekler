using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warehouse.Admin
{
    public partial class AddStore : System.Web.UI.Page
    {
        WarehouseDBEntities dm = new WarehouseDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            SupplierStore s = new SupplierStore();
            if(tb_name.Text != "")
            {
                s.StoreName = tb_name.Text;
                s.activity = cb_activity.Checked;
            }
            dm.SupplierStore.Add(s);
            dm.SaveChanges();
          
            
           
        }
    }
}