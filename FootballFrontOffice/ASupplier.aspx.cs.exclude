using FootballClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ASupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        ASupplier.SupplierNo = txtSupplier.Text;
        Session["ASupplier"] = ASupplier;
        Response.Redirect("SupplierViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        Int32 SupplierNo;
        Boolean Found = false;
        SupplierNo = Convert.ToInt32(txtSupplier.Text);
        Found = ASupplier.Find(SupplierNo);
        if (Found == true)
        {
            txtSupplier.Text = ASupplier.Supplier;
            txtPostCode.Text = ASupplier.PostCode;
            txtDateAdded.Text = ASupplier.DateAdded;


        }
    }
}