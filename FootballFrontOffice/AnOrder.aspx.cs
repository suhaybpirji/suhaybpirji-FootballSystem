using System;
using FootballClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the customer name
        string CustomerName = TextBoxCustomerName.Text;
        //capture the order date
        string OrderDate = TextBoxOrderDate.Text;
        //capture the order price
        string OrderPrice = TextBoxOrderPrice.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
        if (Error == "")
        {
            //capture the customer name
            AnOrder.CustomerName = CustomerName;
            //capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the order price
            AnOrder.OrderPrice = Convert.ToDecimal(OrderPrice);
            //store the order in the session object
            Session["AnOrder"] = AnOrder;
            //rredirect to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(TextBoxOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            TextBoxOrderNo.Text = AnOrder.OrderNo.ToString();
            TextBoxCustomerName.Text = AnOrder.CustomerName;
            TextBoxOrderDate.Text = AnOrder.OrderDate.ToString();
            TextBoxOrderPrice.Text = AnOrder.OrderPrice.ToString();
        }
    }
}