using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestProjectLP.AssertionExtension
{
    [TestClass]
    public class CustomAssertionTest
    {
        [TestMethod]
        public void TestMethodCustomAssertion()
        {
            // Custom Assert (not built in)
            //Assert.That.IsOfType<int>("hello");
            Assert.That.IsOfType<int>(3);

        }
    }
}
