using System;
using FootballClasses;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of the clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff first name
        AStaff.FirstName = txtFirstName.Text;
        //store the address in the session object
        Session["AStaff"] = AStaff;
        //redirect to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}