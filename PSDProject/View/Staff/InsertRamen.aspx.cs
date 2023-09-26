using PSDProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View.Staff
{
    public partial class InsertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            String meat = MeatList.SelectedValue.ToString();
            int price = int.Parse(priceTxt.Text);
            statusLbl.Text = MainController.insertRamen(nameTxt.Text, meat, brothTxt.Text, price);
        }
    }
}