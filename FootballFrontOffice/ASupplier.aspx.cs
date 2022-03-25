using FootballClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ASupplier : System.Web.UI.Page
{
    Int32 SupplierNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
        if (IsPostBack == false)
        {
            //populate the list of staff first name
            DisplaySupplier();
            //if this is not a new record
            if (SupplierNo != -1)
            {
                //display the current data for the record
                DisplaySupplier();
            }
        }



        }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (SupplierNo == -1)
        {
            Add();


        }
        else
        {
            Update();
                
        }
        Response.Redirect("SupplierPage.aspx");
       
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        Int32 SupplierNo;
        Boolean Found = false;
        SupplierNo = Convert.ToInt32(txtSupplier.Text);
        Found = ASupplier.Find(SupplierNo);
        if (Found == true)
        {
            txtSupplier.Text = ASupplier.Supplier;
            txtPostCode.Text = ASupplier.PostCode;
            txtDateAdded.Text = ASupplier.DateAdded;


        }
    }

        void Add()
        {


            FootballClasses.clsSupplierCollection SupplierBook = new FootballClasses.clsSupplierCollection();
            String Error = SupplierBook.ThisSupplier.Valid(txtDateAdded.Text, txtPostCode.Text, txtSupplier.Text);
            if (Error == "")
            {
                SupplierBook.ThisSupplier.SupplierNo = Convert.ToInt32(txtSupplier.Text);
                SupplierBook.ThisSupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                SupplierBook.ThisSupplier.PostCode = (txtPostCode).Text;
                SupplierBook.ThisSupplier.Active = Active.Checked;

            SupplierBook.Add();


            }
            else
            {
                lblError.Text = "There were problems with the data entered " + Error;
            }

        }
    void Update()
    {


        FootballClasses.clsSupplierCollection SupplierBook = new FootballClasses.clsSupplierCollection();
        String Error = SupplierBook.ThisSupplier.Valid(txtDateAdded.Text, txtPostCode.Text, txtSupplier.Text);
        if (Error == "")
        {
            SupplierBook.ThisSupplier.SupplierNo = Convert.ToInt32(txtSupplier.Text);
            SupplierBook.ThisSupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            SupplierBook.ThisSupplier.PostCode = (txtPostCode).Text;
            SupplierBook.ThisSupplier.Active = Active.Checked;

            SupplierBook.Add();


        }
        else
        {
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    void DisplaySupplier()
    {
        //create an instance of the staff book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to update
        SupplierBook.ThisSupplier.Find(SupplierNo);
        //display the data for this record
        txtSupplier.Text = SupplierBook.ThisSupplier.Supplier;
        txtPostCode.Text = SupplierBook.ThisSupplier.PostCode;
        txtDateAdded.Text = SupplierBook.ThisSupplier.DateAdded.ToString();
        Active.Checked = SupplierBook.ThisSupplier.Active;
    }



}
