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

        public bool Find (int SupplierNo)
        {
            
                //this line of code sends data out of the property
                mSupplierNo = 21;
                mPostCode = "LE1";
                mActive = true;
                mDateAdded = Convert.ToDateTime("16/9/2015");
                return true;
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

       
    }
}




