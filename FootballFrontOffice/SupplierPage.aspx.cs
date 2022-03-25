using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Int32 SupplierNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
        if (IsPostBack == false)
        {
            DisplaySupplier();
        }

    }
    

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierNo"] = -1;
        Response.Redirect("ASupplier.aspx");
    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierNo;
        if (lstSuppliers.SelectedIndex != -1) 
        {
            SupplierNo = Convert.ToInt32(lstSuppliers.SelectedValue);
            Session["SupplierNo"] = SupplierNo;
            Response.Redirect("SupplierDelete.aspx");
        }

        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
        
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 SupplierNo;
        //if a record has been selected from the list
        if (lstSupplier.SelectedIndex != -1)
        {
            //get the primary key value of the record to be deleted
            SupplierNo = Convert.ToInt32(lstSupplier.SelectedValue);
            //store the data in the session object
            Session["SupplierNo"] = SupplierNo;
            //redirect to the edit page
            Response.Redirect("AStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }




    void DisplaySupplier()
    {
        FootballClasses.clsSupplierCollection Suppliers = new FootballClasses.clsSupplierCollection();
        lstSuppliers.DataSource = Suppliers.SuppliersList;
        lstSuppliers.DataValueField = "SupplierNo";
        lstSuppliers.DataTextField = "PostCode";
        lstSuppliers.DataBind();



    }






}