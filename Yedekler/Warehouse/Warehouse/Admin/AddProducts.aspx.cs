using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warehouse.Admin
{
    public partial class AddProducts : System.Web.UI.Page
    {
        WarehouseDBEntities dm = new WarehouseDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            ddl_category.DataTextField = "category";
            ddl_category.DataValueField = "ID";
            ddl_category.DataSource = dm.ProductCategorys.ToList();
            ddl_category.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
           pnl_suc.Visible = false;



                Products p = new Products()
                {

                    name = tb_name.Text,
                    CategoryID = Convert.ToInt32(ddl_category.SelectedItem.Value),
                    activity = cb_activity.Checked,
                    stock = Convert.ToInt32(tb_stock.Text),
                    Price = Convert.ToDecimal(tb_price.Text),




                };

                dm.Products.Add(p);
                dm.SaveChanges();
            
            tb_name.Text = "";
            tb_price.Text = "";
            tb_stock.Text = "";
            pnl_suc.Visible = true;






        }
    }
}