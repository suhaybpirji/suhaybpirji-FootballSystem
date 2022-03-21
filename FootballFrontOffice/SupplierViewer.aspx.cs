using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        ASupplier = (clsSupplier)Session["ASupplier"];
        Response.Write(ASupplier.SupplierNo);
    }
}