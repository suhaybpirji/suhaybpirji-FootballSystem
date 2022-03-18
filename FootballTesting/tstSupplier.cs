using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FootballTesting
{
    [TestClass]
    public class tstSupplier
    {
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



        }

    class clsSupplier
    {
        public bool Active { get; internal set; }
        public int SupplierNo { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public string PostCode { get; internal set; }
    }
}


