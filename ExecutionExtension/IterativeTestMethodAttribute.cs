using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestProjectLP.ExecutionExtension
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class IterativeTestMethodAttribute : TestMethodAttribute
    {
        private int _stabilityThreshold;

        public IterativeTestMethodAttribute(int stabilityThreshold)
        {
            _stabilityThreshold = stabilityThreshold;
        }

        public override TestResult[] Execute(ITestMethod testMethod)
        {
            var results = new List<TestResult>();
            TestResult[] currentResults;

            for (int i = 0; i < this._stabilityThreshold; i++)
            {
                currentResults = base.Execute(testMethod);
                results.AddRange(currentResults);
            }
            return results.ToArray();
        }
    }
}
