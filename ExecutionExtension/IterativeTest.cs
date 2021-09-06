using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestProjectLP.ExecutionExtension
{
    [TestClass]
    public class IterativeTest
    {
        private static int counter;

        [IterativeTestMethod(3)]    // this will execute this method three times if there is a particular method we are interested in checking more...
        public void FlakyTest()
        {
            counter++;
            //if (counter > 2)    // forcing the test to fail before the stability threshold of the IterativeTestMethod attribute!
            //{
            //    Assert.Fail();
            //}
            if (counter > 4)    // forcing the test to fail before the stability threshold of the IterativeTestMethod attribute!
            {
                Assert.Fail();
            }
        }
    }
}
