using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProjectLP.DataDrivenExtension
{
    [TestClass]
    public class DataRowUnitTests
    {
        [DataTestMethod]
        [DataRow(1,2,3)]
        [DataRow(2,5,7)]
        [DataRow(4,6,10)]
        public void DataRowAddTest(int a, int b, int expected)
        {
            int actual = a + b;
            Assert.AreEqual(expected, actual);
        }
    }
}