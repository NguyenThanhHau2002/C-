using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bai10;
using System.Linq;

namespace LargestTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestLargest()
        {
            string arrayStr = TestContext.DataRow[0].ToString();
            int expectedResult = int.Parse(TestContext.DataRow[1].ToString());
            int[] a = string.IsNullOrWhiteSpace(arrayStr) ? new int[0] : arrayStr.Split(',').Select(int.Parse).ToArray();

            int result = Largest.GiaTriLon(a);
            Assert.AreEqual(expectedResult, result, "The largest value calculation is incorrect.");
        }
    }
}
