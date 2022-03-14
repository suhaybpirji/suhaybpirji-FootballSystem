using System;
using FootballClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff name for this entry
        Response.Write(AStaff. FirstName);

        Response.Write(AStaff. Surname);

        Response.Write(AStaff. Income);

        Response.Write(AStaff. DateAdded);
    }
}