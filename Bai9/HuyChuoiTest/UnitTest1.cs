using Bai9;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HuyChuoiTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestHuyChuoi()
        {
            string intput = TestContext.DataRow[0].ToString();
            int n = int.Parse(TestContext.DataRow[1].ToString());
            int p = int.Parse(TestContext.DataRow[2].ToString());
            string expectedResult = TestContext.DataRow[3].ToString();

            string result = HuyChuoi.Unchain(intput, n, p);
            Assert.AreEqual(expectedResult, result, "The result of HuyChuoi is incorrect.");
        }
    }
}