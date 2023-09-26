using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View.Admin
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["roleId"] == 1)
            {
                roleLbl.Text = "Customer";
                return;
            }
            else if ((int)Session["roleId"] == 2)
            {
                roleLbl.Text = "Staff";
            }
            else
            {
                roleLbl.Text = "Admin";
            }

            userData.DataSource = MainRepository.getAllUser();
            userData.DataBind();
        }
    }
}

