using FootballClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace FootballTesting
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();

            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "LE1 6RL";
            TestList.Add(TestItem);

            AllSuppliers.SuppliersList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllSuppliers.SuppliersList, TestList);

        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Int32 SomeCount = 2;
            AllSuppliers.Count = SomeCount;

            //test to see that it exists
            Assert.AreEqual(AllSuppliers.Count, SomeCount);
        }
        [TestMethod]
        public void ThisSupplierProperty()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();

            TestSupplier.Active = true;
            TestSupplier.DateAdded = DateTime.Now.Date;
            TestSupplier.PostCode = "LE1 6RL";

            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that it exists
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);



        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();

            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "LE1 6RL";

            AllSuppliers.SuppliersList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.SupplierNo = 24;
            TestItem.PostCode = "LE1 6RL";
            TestItem.DateAdded = DateTime.Now.Date;
            //set Supplier to the test data
            AllSupplier.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //set the primary key of the test data
            TestItem.SupplierNo = PrimaryKey;
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.SupplierNo = 1;
            TestItem.PostCode = "LE1";
            TestItem.DateAdded = DateTime.Now.Date;
            //set Supplier to the test data
            AllSupplier.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //set the primary key of the test data
            TestItem.SupplierNo = PrimaryKey;
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //delete the record
            AllSupplier.Delete();
            //now find the record
            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.PostCode = "LE1";
            TestItem.SupplierNo = "8";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisSupplier to the test data
            AllSupplier.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSupplier.Add();
            //set the primary key of the test data
            TestItem.SupplierNo = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.PostCode = "LE3";
            TestItem.SupplierNo = "9";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllSupplier.ThisSupplier = TestItem;
            //update the record
            AllSupplier.Update();
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see Supplier matches the test data
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }
    }
}


    
