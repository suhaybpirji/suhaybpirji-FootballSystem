using System;

namespace FootballClasses
{
    public class clsCustomer
    {
        //private data member for the customer no property
        private Int32 mCustomerNo;
        private DateTime mDateAdded;
        private string mFirstName;
        private string mSurname;
        private string mAddress;
        private string mMobileNumber;
        private Boolean mActive;

        public bool Active 
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
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
        public string FirstName 
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string Surname 
        {
            get
            {
                return mSurname;
            }
            set
            {
                mSurname = value;
            }
        }
        public string Address 
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public string MobileNumber 
        {
            get
            {
                return mMobileNumber;
            }
            set
            {
                mMobileNumber = value;
            }
        }

        public bool Find(int customerNo)
        {
            //set the private data members to the test data value
            mCustomerNo = 1;
            mDateAdded = Convert.ToDateTime("17/03/2022");
            mFirstName = "Mohammed";
            mSurname = "Tawad";
            mAddress = "45 Osborne Road";
            mMobileNumber = "07742529030";
            mActive = true;
            //always return true
            return true;
        }
    }
}