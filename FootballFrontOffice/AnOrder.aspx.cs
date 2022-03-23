using System;
using FootballClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order no
        AnOrder.CustomerName = TextBoxCustomerName.Text;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //rredirect to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}