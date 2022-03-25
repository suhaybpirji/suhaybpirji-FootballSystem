using FootballClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierDelete : System.Web.UI.Page
{
    Int32 SupplierNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
    }
    void DeleteSupplier()
    {
        //function to delete the selected record

        //create a new instance of the staff book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to delete
        SupplierBook.ThisSupplier.Find(SupplierNo);
        //delete the record
        SupplierBook.Delete();
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteSupplier();
        //redirect back to main page
        Response.Redirect("SupplierPage.aspx");
    }

}