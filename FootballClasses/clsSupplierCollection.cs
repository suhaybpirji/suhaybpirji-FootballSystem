using System;
using FootballClasses;
using System.Collections.Generic;

namespace FootballClasses
{
    public class clsSupplierCollection
    {

        List<clsSupplier> mSuppliersList = new List<clsSupplier>();

        clsSupplier mThisSupplier = new clsSupplier();


        public List<clsSupplier> SuppliersList
        {
            get
            {
                return mSuppliersList;

            }
            set
            {
                mSuppliersList = value;

            }

        }
        public int Count

        {
            get
            {
                return mSuppliersList.Count;
            }
            set
            {

            }

        }

        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;

            }


        }


        public clsSupplierCollection()
        {
            clsSupplier TestItem = new clsSupplier();
            TestItem.Active = true;
            TestItem.DateAdded = System.DateTime.Now.Date;
            TestItem.PostCode = "LE1 6RL";

            TestItem = new clsSupplier();

            TestItem.Active = true;
            TestItem.DateAdded = System.DateTime.Now.Date;
            TestItem.PostCode = "LE1 5TY";

        }





        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierNo", mThisSupplier.SupplierNo);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@PostCode", mThisSupplier.PostCode);
            DB.AddParameter("@Active", mThisSupplier.Active);

            return DB.Execute("sproc_tblSupplier_Insert");


        }
        public void Update()
        {
            //update an existing record based on the values of This Staff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure

            DB.AddParameter("@SupplierNo", mThisSupplier.SupplierNo);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@PostCode", mThisSupplier.PostCode);
            DB.AddParameter("@Active", mThisSupplier.Active);

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierNo", mThisSupplier.SupplierNo);
            DB.Execute("sproc_tblSupplier_Delete");
        }
    }

    public clsSupplierCollection()

    {

        Int32 Index = 0;
        Int32 RecordCount = 0;
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblSupplier_SelectAll");
        RecordCount = DB.Count;
        while (Index < RecordCount)
        {
            clsSupplier ASupplier = new clsSupplier();
            ASupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
            ASupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
            ASupplier.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
            mSuppliersList.Add(ASupplier);
            Index++;
        }
    }

    public void ReportByPostCode(string PostCode)
    {
        //filters the records based on a full or partial first name 
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //send the first name parameter to the database
        DB.AddParameter("@PostCode", PostCode);
        //execute the stored procedure
        DB.Execute("sproc_tblSupplier_FilterByPostCode");
        //populate the array list with the data table
        PopulateArray(DB);

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in th eparameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            List<clsSupplier>
                    //clear the private array List
                    mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff record
                clsSupplier ASupplier = new clsSupplier();
                //read in the fields from the current record
                ASupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ASupplier.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ASupplier.Supplier = Convert.ToString(DB.DataTable.Rows[Index]["Supplier"]);
                ASupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mSupplierList.Add(ASupplier);
                //point at the next record
                Index++;
            }
        }
    }
}

  
