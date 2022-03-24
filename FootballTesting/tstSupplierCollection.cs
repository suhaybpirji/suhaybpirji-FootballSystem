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






    }

    }
