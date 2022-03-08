using System;
using FootballClasses;

   public partial class _Default : System.Web.UI.Page
   {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff collection
        FootballClasses.clsStaffCollection Staff = new FootballClasses.clsStaffCollection();
        //set the data source to the list of staff in the collection
        lstStaff.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaff.DataValueField = "StaffNo";
        //set the data field to display
        lstStaff.DataValueField = "FirstName";
        //bind the data to the list
        lstStaff.DataBind();
    }
  }