using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1.First_Web_Application
{
    public partial class Demo_Web_Form : System.Web.UI.Page
    {
        //Page Load_ Event Load Like Body
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblMessages.Text += "Load Page Event<br/>";
            }
        }

        //Page Init_ Event Load First Like Header
        protected void Page_Init(object sender, EventArgs e)
        {
            lblMessages.Text += "Create Page Event<br/>";
        }

        //Page PreRender_ Event Load First Like Footer
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblMessages.Text += "PreRender Page Event<br/>";
            }
        }
        //Object Event
        protected void btnClick_Click(object sender, EventArgs e)
        {
            lblMessages.Text += "Hello World - Page Click Btn<br/>";
        }
    }
}