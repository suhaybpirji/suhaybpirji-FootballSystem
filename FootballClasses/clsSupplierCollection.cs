using System;
using System.Collections.Generic;

namespace FootballClasses
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSuppliersList = new List<clsSupplier>();
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




        public clsSupplier ThisSupplier { get; set; }
    }

    public clsSupplierCollection()
    {

        Int32 Index = 0;
        Int32 RecordCount = 0;
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("Sproc_tblSupplier_SelectAll");
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
}