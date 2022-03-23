using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClasses
{
    public class clsOrder
    {
        //OrderNo private member variable
        private Int32 mOrderNo;
        public Int32 OrderNo
        {
            get
            {
                //return the private data
                //this line of code sends data out of the property
                return mOrderNo;
            }
            set
            {
                //set the private data
                //this line of code allows data into the property
                mOrderNo = value;
            }
        }
        //OrderDate private member variable
        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the private data
                mOrderDate = value;
            }
        }
        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                //return the private data
                return mCustomerName;
            }
            set
            {
                //set the private data
                mCustomerName = value;
            }
        }
        private decimal mOrderPrice;
        public decimal OrderPrice
        {
            get
            {
                //return the private data
                return mOrderPrice;
            }
            set
            {
                //set the private data
                mOrderPrice = value;
            }
        }

        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sporc_tblOrder_FilterByOrderNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
            mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
            mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
            mOrderPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderPrice"]);
            //return that everything worked OK
            return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string customerName, string orderDate, string orderPrice)
        {
            //create a string variable to store the error
            String Error = "";
            //creaye a tempory variable to store data values
            DateTime DateTemp;
            //if the CustomerName is blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Name no may not be blank : ";
            }
            if (customerName.Length > 50)
            {
                //record the error
                Error = Error + "The Customer Name must be less than 50 characters : ";
            }
            try
            {

                //copy the orderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past :";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //if the OrderPrice is blank
            if (orderPrice.Length == 0)
            {
                //record the error
                Error = Error + "The Order Price no may not be blank : ";
            }
            if (orderPrice.Length > 18)
            {
                //record the error
                Error = Error + "The Order Price must be less than 18 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}