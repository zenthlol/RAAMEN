using PSDProject.Controller;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View.Staff
{
    public partial class UpdateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenData.DataSource = MainRepository.getAllRamen();
            ramenData.DataBind();
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
           
            int id = int.Parse(idTxt.Text);
            string name = nameTxt.Text;
            string meat = MeatList.SelectedValue.ToString();
            string broth = brothTxt.Text;
            int price = int.Parse(priceTxt.Text);
            statusLbl.Text = MainController.updateRamen(id, name, meat, broth, price);
        }

        protected void ramenData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Raman Ramen = MainRepository.getRamenBasedOnID(int.Parse(ramenData.SelectedRow.Cells[1].Text));

            idTxt.Text = Ramen.RamenId.ToString();
            
        }
    }
}