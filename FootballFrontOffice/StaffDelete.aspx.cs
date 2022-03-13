using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootballClasses;

public partial class StaffDelete : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    void DeleteStaff()
    {
        //function to delete the selected record

        //create a new instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(StaffNo);
        //delete the record
        StaffBook.Delete();
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteStaff();
        //redirect back to main page
        Response.Redirect("StaffPage.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}