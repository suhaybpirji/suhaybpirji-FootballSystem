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
        string SupplierNo = txtSupplier.Text;
        string DateAdded = txtDateAdded.Text;
        string PostCode = txtPostCode.Text;
        string Error = "";

        Error = ASupplier.Valid(SupplierNo, txtPostCode, DateAdded);
        if (Error == "")
        {

            ASupplier.SupplierNo = txtSupplier.Text;
            ASupplier.PostCode = txtPostCode.Text;
            ASupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            Session["ASupplier"] = ASupplier;
            Response.Redirect("SupplierViewer.aspx");
        }
        else
        {
            lblError.Text=Error;
        }
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