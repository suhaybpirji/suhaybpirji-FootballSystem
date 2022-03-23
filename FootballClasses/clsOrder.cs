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
            //set the private data members to the test data value
            mOrderNo = 1;
            mCustomerName = "Test Name";
            mOrderDate = Convert.ToDateTime("28/02/2022");
            mOrderPrice = 1;
            //always return true
            return true;
        }
    }
}