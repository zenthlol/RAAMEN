using PSDProject.Controller;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.Cookies["username"] != null && Request.Cookies["password"] != null)
                {
                    usernameTxt.Text = Request.Cookies["username"].Value;
                    passwordTxt.Text = Request.Cookies["password"].Value;
                }
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            errorMessage.Text = MainController.userLogin(usernameTxt.Text, passwordTxt.Text);

            if (errorMessage.Text == "true")
            {
                
                User user = MainRepository.getUser(usernameTxt.Text, passwordTxt.Text);

                Session["userName"] = user.UserName.ToString();
                Session["userId"] = user.UserId;
                Session["roleId"] = user.RoleId;

              
                if (rememberMe.Checked)
                {
                    Response.Cookies["username"].Value = usernameTxt.Text;
                    Response.Cookies["password"].Value = passwordTxt.Text;
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(30);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(30);
                    
                }
                else
                {
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);
                }
                

                if (user.RoleId == 1)
                {
                    Response.Redirect("Customer/Home.aspx");
                }
                else if (user.RoleId == 2)
                {
                    Response.Redirect("Staff/Home.aspx");
                }
                else if (user.RoleId == 3)
                {
                    Response.Redirect("Admin/Home.aspx");
                }
            }  
            
        }

        
    }
}

