using System;
using FootballClasses;

public partial class AStaff : System.Web.UI.Page
{
    Int32 StaffNo;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            //populate the list of staff first name
            DisplayStaff();
            //if this is not a new record
            if (StaffNo != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
      
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
       if (StaffNo == -1)
       {
            //add the new record
            Add();
       }
       else
       {
            //update the record
            Update();
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

    void Update()
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
            StaffBook.Update();
            //qll eon3 so redirect back to main page
            Response.Redirect("StaffPage.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

        void DisplayStaff()
        {
            //create an instance of the staff book
            clsStaffCollection StaffBook = new clsStaffCollection();
            //find the record to update
            StaffBook.ThisStaff.Find(StaffNo);
            //display the data for this record
            txtFirstName.Text = StaffBook.ThisStaff.FirstName;
            txtSurname.Text = StaffBook.ThisStaff.Surname;
            txtIncome.Text = StaffBook.ThisStaff.Income.ToString();
            txtDateAdded.Text = StaffBook.ThisStaff.DateAdded.ToString();
            chkActive.Checked = StaffBook.ThisStaff.Active;
        }

}
    
