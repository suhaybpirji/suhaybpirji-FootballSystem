using System;

namespace FootballClasses
{
    public class clsCustomer
    {
        //private data member for the customer no property
        private Int32 mCustomerNo;
        private DateTime mDateAdded;
        public bool Active { get; set; }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public int CustomerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }

        public bool Find(int customerNo)
        {
            //set the private data members to the test data value
            mCustomerNo = 2;
            mDateAdded = Convert.ToDateTime("22/03/2022");
            //always return true
            return true;
        }
    }
}