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
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //check the property
            if (ASupplier.PostCode != "LE1")
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
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //check the property
            if (ASupplier.Active != true)
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

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "L"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE111"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE1 1HF"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE1"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid( PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void PostCodeNoMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "a"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


      
    

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE1 6RLL"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aa"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInavlidData()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //set the dateadded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = ASupplier.Valid(PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}







