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
    }
}
