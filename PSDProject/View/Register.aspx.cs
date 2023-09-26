using PSDProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string Gender = GenderList.SelectedValue.ToString();
            statusLbl.Text = MainController.userRegister(usernameTxt.Text, emailTxt.Text, Gender, passwordTxt.Text, passwordConfTxt.Text);

            if (statusLbl.Text.Equals("Successful"))
            {
                Response.Redirect("Login.aspx");
            }
            
        }
    }
}