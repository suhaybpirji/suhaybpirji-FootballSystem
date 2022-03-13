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
        //add the new record
        Add();
        //all done so recirect back to main page
        Response.Redirect("StaffPage.aspx");
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
        //function for adding new records

        void Add()
        {
            //create an instance of the staff book
            clsStaffCollection StaffBook = new clsStaffCollection();
            //validate the data on the web form
            string Error = StaffBook.ThisStaff.Valid(txtFirstName.Text, txtSurname.Text, txtIncome.Text, txtDateAdded.Text);
            if (Error == "")
            {
                //get the data entered by the user
                StaffBook.ThisStaff.FirstName = txtFirstName.Text;
                StaffBook.ThisStaff.Surname = txtSurname.Text;
                StaffBook.ThisStaff.Income = Convert.ToDouble(txtIncome.Text);
                StaffBook.ThisStaff.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                StaffBook.ThisStaff.Active = chkActive.Checked;
                //add the record
                StaffBook.Add();
                //qll eon3 so redirect back to main page
                Response.Redirect("StaffPage.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }
        
        }
}
    
