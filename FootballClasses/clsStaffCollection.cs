using System;
using System.Collections.Generic;

namespace FootballClasses
{
    public class clsStaffCollection
    {
        //prvate data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
          
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@Income", mThisStaff.Income);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of This Staff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@Income", mThisStaff.Income);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByFirstName(string FirstName)
        {
            //filters the records based on a full or partial first name 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the first name parameter to the database
            DB.AddParameter("@FirstName", FirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByFirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in th eparameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array List
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff record
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
    }
}