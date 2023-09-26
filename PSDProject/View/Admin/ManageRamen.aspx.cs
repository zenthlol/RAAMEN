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
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenData.DataSource = MainRepository.getAllRamen();
            ramenData.DataBind();
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertRamen.aspx");
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateRamen.aspx");
        }


        protected void ramenData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Raman ramen = MainRepository.getRamenBasedOnID(int.Parse(ramenData.SelectedRow.Cells[1].Text));
            deleteLbl.Text = MainController.deleteRamen(ramen.RamenId);
        }
    }
}