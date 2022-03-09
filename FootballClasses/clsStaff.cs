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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff no to search for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mIncome = Convert.ToDouble(DB.DataTable.Rows[0]["Income"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string firstName, string surname, string income, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;
            //if the FirstName is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The house not may be blank : ";
            }
            //
            if (firstName.Length < 3)
            {
                //record the error
                Error = Error + "The first name must be no less than 3 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";

                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //if the surname is blank
            if (surname.Length == 0)
            {
                //record the error 
                Error = Error + "The surname may not be blank : ";
            }
            //if the surname is To short
            if (surname.Length < 3)
            {
                //record the error
                Error = Error + "The surname must be more than 3 characters : ";
            }
            //if the income is blank
            if (income.Length == 0)
            {
                //record the error
                Error = Error + "Income  must not be blank  : ";
            }
            //if the surname is To short
            if (income.Length < 3)
            {
                //record the error
                Error = Error + "Income must be more than 3 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}