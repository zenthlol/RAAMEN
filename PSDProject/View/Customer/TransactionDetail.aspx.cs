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
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Header header = MainRepository.getHeaderBasedOnID((int)Session["headerId"]);
            Detail detail = MainRepository.getDetailBasedOnID(header.HeaderId);
            Raman ramen = MainRepository.getRamenBasedOnID((int)detail.RamenId);

            headerIdLbl.Text = header.HeaderId.ToString();
            detailIdLbl.Text = detail.DetailID.ToString();
            dateLbl.Text = header.Date.ToString();
            ramenLbl.Text = ramen.Name;
            brothLbl.Text = ramen.Borth;
            priceLbl.Text = ramen.Price.ToString();
            quantityLbl.Text = detail.Quantity.ToString();
            totalLbl.Text = (ramen.Price * detail.Quantity).ToString();

        }
    }
}