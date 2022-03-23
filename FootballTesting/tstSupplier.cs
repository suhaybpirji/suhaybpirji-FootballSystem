using FootballClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace FootballTesting
{
    [TestClass]
    public class tstSupplier
    {
        // TestData
        string DateAdded = DateTime.Now.Date.ToString();
        string PostCode = "LE1";


        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);

        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean TestData = true;
            ASupplier.Active = TestData;
            Assert.AreEqual(ASupplier.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.DateAdded = TestData;
            Assert.AreEqual(ASupplier.Active, TestData);
        }

        [TestMethod]
        public void SupplierNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ASupplier.SupplierNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierNo, TestData);
        }


        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            ASupplier.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.PostCode, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean Found = false;
            //assign the data to the property
            Int32 SupplierNo = 21;
            // fix find
            Found = ASupplier.Find(SupplierNo);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierNoFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean Found = false;
            Boolean OK = true;
            //assign the data to the property
            Int32 SupplierNo = 21;
            // fix find
            Found = ASupplier.Find(SupplierNo);
            if (ASupplier.SupplierNo != 21)
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean Found = false;
            Boolean OK = true;
            //assign the data to the property
            Int32 SupplierNo = 21;
            // fix find
            Found = ASupplier.Find(SupplierNo);
            if (ASupplier.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnAddress = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = AnAddress.Find(SupplierNo);
            //check the property
            if (AnAddress.PostCode != "LE1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnAddress = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = AnAddress.Find(SupplierNo);
            //check the property
            if (AnAddress.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            String Error = "";
            Error = ASupplier.Valid(DateAdded, PostCode);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");




        }


        }
    }







