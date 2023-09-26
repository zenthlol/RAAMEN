using PSDProject.Controller;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View.Admin
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUser();
            }
        }
        void LoadUser()
        {
            int userId = (int)Session["userId"];

            User user = MainRepository.getUserBasedOnID(userId);
            usernameTxt.Text = user.UserName;
            emailTxt.Text = user.Email;
            passwordTxt.Text = user.Password;
        }
        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int userId = (int)Session["userId"];
            User user = MainRepository.getUserBasedOnID(userId);

            string gender = GenderList.SelectedValue.ToString();
            statusLbl.Text = MainController.updateUser(userId, usernameTxt.Text, emailTxt.Text, gender, passwordTxt.Text);
        }
    }
}