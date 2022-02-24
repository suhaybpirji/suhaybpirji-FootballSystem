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
        string FirstName = txtFirstName.Text;
        //capture the staff surname
        string Surname = txtSurname.Text;
        //capture the staff income
        string Income = txtIncome.Text;
        //capture dateadded
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(FirstName, Surname, Income, DateAdded);
        if (Error == "")
        {
            //capture the first name 
            AStaff.FirstName = FirstName;
            //capture the surname
            AStaff.Surname = Surname;
            //capture the income
            AStaff.Income = Convert.ToDouble( Income);
            //capture the dateadded
            AStaff.DateAdded = Convert.ToDateTime(DateAdded);
            //store the address in the session object
            Session["AStaff"] = AStaff;
            //redirect to the viewer page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //find the record
        Found = AStaff.Find(StaffNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AStaff.FirstName;
            txtSurname.Text = AStaff.Surname;
            txtIncome.Text = AStaff.Income.ToString();
            txtDateAdded.Text = AStaff.DateAdded.ToString();
        }
    }
}