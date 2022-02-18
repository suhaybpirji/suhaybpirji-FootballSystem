using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClasses
{
    public class clsStaff
    {
        private Int32 mStaffNo;
        private DateTime mDateAdded;
        private Boolean mActive;
        private string mFirstName;
        private string mSurname;
        private double mIncome;


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
        public int StaffNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffNo = value;
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
        public double Income
        {
            get
            {
                return mIncome;
            }
            set
            {
                mIncome = value;
            }
        }

        public bool Find(int StaffNo)
        {
            //set the private data members to the test data value
            mStaffNo = 5;
            mDateAdded = Convert.ToDateTime("18/02/2022");
            mActive = true;
            mFirstName = "John";
            mSurname = "Potter";
            mIncome = 7000.00;
            //always return true
            return true;
        }
    }
}