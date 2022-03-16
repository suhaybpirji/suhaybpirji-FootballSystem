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
    }

    class clsOrder
    {
    }
}
