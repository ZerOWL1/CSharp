using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _2.ASP.NET_DBContext.Models;

namespace _2.ASP.NET_DBContext
{
    public partial class index : System.Web.UI.Page
    {
        private CategoryControl cc = new CategoryControl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                /*  1. Load Cate
                    2. Load Dgv
                - BTVN: Add 2 New Columns
                 
                 */
                //Load Data Here
                ddlCategory.DataSource = cc.GetAllCategory();
                //Text in DB
                ddlCategory.DataTextField = "CategoryName";
                //ID in DB
                ddlCategory.DataValueField = "CategoryID";
                //Gan Du Lieu
                ddlCategory.DataBind();

                //Load Dgv
                int cateID = Convert.ToInt32(ddlCategory.SelectedValue);
                gvProduct.DataSource = cc.GetProductByCateI(cateID);
                gvProduct.DataBind();
            }
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get ID
            int cateID = Convert.ToInt32(ddlCategory.SelectedValue);
            gvProduct.DataSource = cc.GetProductByCateI(cateID);
            gvProduct.DataBind();
        }
    }
}