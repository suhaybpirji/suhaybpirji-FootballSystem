using System;
using FootballClasses;

   public partial class _Default : System.Web.UI.Page
   {
    Int32 StaffNo;
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
        //get the number of the address to be proccesed
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        //if this is the first time the page is displayed
        if (StaffNo != -1)
        {
            //update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff Book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffNo);
        //display the data for this record
        txtFirstName.Text = StaffBook.ThisStaff.FirstName;
        txtSurname.Text = StaffBook.ThisStaff.Surname;
        txtIncome.Text = StaffBook.ThisStaff.Income;
        txtDateAdded.Text = StaffBook.ThisStaff.DateAdded;
        chkActive.Checked = StaffBook.ThisStaff.Active;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AStaff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to be deleted
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to the delete page
            Response.Redirect("StaffDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to be deleted
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to the delete page
            Response.Redirect("StaffPage.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
