using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClasses
{
    public class tstSupplierCollection
   
    {
    }
    [TestMethod]
    public void InstanceOK()
    {
        clsSupplierCollection AllSuppliers = new clsSupplierCollection();
        Assert.IsNotNull(AllSuppliers);
    }
}
