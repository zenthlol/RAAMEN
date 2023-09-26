using PSDProject.Controller;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View.Customer
{
    public partial class OrderRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenData.DataSource = MainRepository.getAllRamen();
            ramenData.DataBind();

            cartData.DataSource = MainRepository.getAllCart();
            cartData.DataBind();
        }

        protected void orderBtn_Click(object sender, EventArgs e)
        {

            Raman ramen = MainRepository.getRamenBasedOnID(int.Parse(idTxt.Text));
            int quantity = int.Parse(quantityTxt.Text);
            int userId = (int)Session["userid"];
            statusLbl.Text = MainController.addCart(ramen.RamenId, userId ,quantity);
            Page_Load(sender, e);
        }

        protected void ramenData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Raman Ramen = MainRepository.getRamenBasedOnID(int.Parse(ramenData.SelectedRow.Cells[1].Text));

            idTxt.Text = Ramen.RamenId.ToString();

        }

        protected void clearBtn_Click(object sender, EventArgs e)
        {

            int userId = (int)Session["userId"];
            statusLbl.Text = MainController.clearUserCart(userId);
        }

        protected void buyBtn_Click(object sender, EventArgs e)
        {
            Raman ramen = MainRepository.getRamenBasedOnID(int.Parse(idTxt.Text));
            int quantity = int.Parse(quantityTxt.Text);
            int userId = (int)Session["userid"];
            statusLbl.Text = MainController.addCart(ramen.RamenId, userId, quantity);
            Page_Load(sender, e);
        }
    }
}