using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MSTestProjectLP.DataDrivenExtension
{
    [TestClass]
    public class DynamicDataUnitTests
    {
        [TestMethod]
        [DynamicData(nameof(GetDataForTest), DynamicDataSourceType.Method)]
        public void DynamicDataTestMethod(int a, int b, int expected)
        {
            int actual = a + b;
            Assert.AreEqual(expected, actual);
        }

        static IEnumerable<object[]> GetDataForTest()
        {
            return new[]
            {
                new object[] { 1,2,3 },
                new object[] { 2,5,7 },
                new object[] { 4,6,10 }
            };
        }
    }
}