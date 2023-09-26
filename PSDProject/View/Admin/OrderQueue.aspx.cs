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
    public partial class OrderQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cartData.DataSource = MainRepository.getAllCart();
            cartData.DataBind();
        }
        protected void handleBtn_Click(object sender, EventArgs e)
        {
            int cartId = int.Parse(idTxt.Text);
            Cart cart = MainRepository.getCartBasedOnID(cartId);
            int staffId = (int)Session["userid"];

            if (cart != null)
            {
                int userId = (int)cart.UserId;
                Header header = MainController.addHeader(userId, staffId);

                MainController.addDetail(header.HeaderId, (int)cart.RamenId, (int)cart.Quantity);

                statusLbl.Text = MainController.clearCart(cartId);
            }
            else
            {
                statusLbl.Text = "Cart Id Invalid";
            }

        }
        protected void cartData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cart cart = MainRepository.getCartBasedOnID(int.Parse(cartData.SelectedRow.Cells[1].Text));

            idTxt.Text = cart.CartId.ToString();
        }
    }
}