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
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = (int)Session["userid"];

            historyData.DataSource = MainRepository.getUserHistory(userId);
            historyData.DataBind();

        }

        protected void historyData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Header header = MainRepository.getHeaderBasedOnID(int.Parse(historyData.SelectedRow.Cells[1].Text));
            
            Session["headerId"] = header.HeaderId;

            Response.Redirect("TransactionDetail.aspx");

            

        }
    }
}