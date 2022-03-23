using FootballClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FootballTesting
{
    [TestClass]
    public class tstOrder
    {
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
            if (AnOrder.OrderDate != Convert.ToDateTime("28/02/2022"))
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
            if (AnOrder.OrderPrice != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
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
            if (AnOrder.CustomerName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }


}