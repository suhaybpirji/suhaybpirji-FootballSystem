    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClasses
{
    public class clsSupplier
    {
        private Int32 mSupplierNo;
        private String mPostCode;
        private Boolean mActive;
        private DateTime mDateAdded;

        public bool Find(int SupplierNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierNo", SupplierNo);
            DB.Execute("sproc_tblSupplier_FilterBySupplierNo");
            if (DB.Count == 1)
            {
                mSupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["True"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["PostCode"]);

                return true;
            }

            else
            {

                return false;
            }



        }

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
        //        private Int32 mSupplierNo;
        //      private String mPostCode;
        //    private Boolean mActive;
        //   private DateTime mDateAdded;
        public Int32 SupplierNo
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierNo;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierNo = value;
            }
        }

        public string PostCode { get; set; }
        public string Supplier { get; set; }

        public string Valid(string dateAdded, string postCode)
        {
            {
                //create a string variable to store the error
                String Error = "";
                //create a temporary variable to store date values
                DateTime DateTemp;
                //if the HouseNo is blank
                if (postCode.Length == 0)
                {
                    //record the error
                    Error = Error + "The house no may not be blank : ";
                }
                //if the house no is greater than 6 characters
                if (postCode.Length > 6)
                {
                    //record the error
                    Error = Error + "The postcode must be less than 6 characters : ";
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
                    //check to see if the date is greater than today's date
                    if (DateTemp > DateTime.Now.Date)
                    {
                        //record the error
                        Error = Error + "The date cannot be in the future : ";
                    }
                }
                catch
                {
                    Error = Error + "the date wa not a valid date";

                }
                //return any error messages
                return Error;
            }


        }

        public string Valid(string text1, string text2, string text3)
        {
            throw new NotImplementedException();
        }
    }
}





