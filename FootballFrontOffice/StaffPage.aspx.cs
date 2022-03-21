using System;
using FootballClasses;

   public partial class _Default : System.Web.UI.Page
   {
    Int32 StaffNo;
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            StaffNo = Convert.ToInt32(Session["StaffNo"]);
            if (IsPostBack == false)
            {
                //update the list box
                DisplayStaff();
            }
    }
    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to the list of staff in the collection
        lstStaff.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaff.DataValueField = "StaffNo";
        //set the data field to display
        lstStaff.DataTextField = "FirstName";
        //bind the data to the data list
        lstStaff.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //////store -1 into the session object to indicate this is a new record
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
            //redirect to the edit page
            Response.Redirect("AStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //this is ol
    }
}
