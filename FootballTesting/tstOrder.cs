using FootballClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FootballTesting
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        string CustomerName = "Sonia Myriam";
        string OrderDate = DateTime.Now.Date.ToString();
        string OrderPrice = "55";

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Paul Pogba";
            //assign the data to the property
            AnOrder.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }
        [TestMethod]
        public void OrderPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            decimal TestData = 1;
            //assign the data to the property
            AnOrder.OrderPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderPrice, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.CustomerName != "Sonia Myriam")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("20/02/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderPrice != 55)
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
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date todays date
            TestDate = DateTime.Now.Date;
            //change the date to wathever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non date value
            string OrderDate = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderPrice = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderPrice = "1"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderPrice = "12"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "12345678912345678"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderPrice = "123456789123456789"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderPrice = "123456789"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderPrice = "12345678912345678912"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}