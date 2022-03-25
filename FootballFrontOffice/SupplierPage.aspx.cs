using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySuppliers();
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
        if (lstSuppliers.SelectedValue != -1) ;
        {
            SupplierNo = Convert.ToInt32(lstSuppliers.SelectedValue);
            Session["SupplierNo"] = SupplierNo;
            Response.Redirect("SupplierDelete.aspx");
        }
        else
        { 

                
            lblError.Text = "Please select "
        }
        
        { 
    }




    void DisplaySuppliers()
    {
        FootballClasses.clsSupplierCollection Suppliers = new FootballClasses.clsSupplierCollection();
        lstSuppliers.DataSource = Suppliers.SuppliersList;
        lstSuppliers.DataValueField = "SupplierNo";
        lstSuppliers.DataTextField = "PostCode";
        lstSuppliers.DataBind();



    }






}