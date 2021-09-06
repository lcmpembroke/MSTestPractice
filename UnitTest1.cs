using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProjectLP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Threading.Thread.Sleep(1500);
        }

        [TestMethod]
        public void TestMethod2()
        {
            System.Threading.Thread.Sleep(100);
        }

        [TestMethod]
        public void TestMethod3()
        {
            System.Threading.Thread.Sleep(1500);
        }

        [TestMethod]
        [DoNotParallelize]
        public void TestMethod4()
        {
            System.Threading.Thread.Sleep(1500);
        }
    }
}
