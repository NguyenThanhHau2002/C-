using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bai8;

namespace SumTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void SumTest()
        {
            string s0Str = TestContext.DataRow[0].ToString();
            string expectedSStr = TestContext.DataRow[1].ToString();
            string expectedKStr = TestContext.DataRow[2].ToString();

            long s0 = 0, expectedS = 0, expectedK = 0;
            long actualS = 0;
            long actualK = 0;
      
            Sum.SumCalculator(s0, out actualS, out actualK);

            Assert.AreEqual(expectedS, actualS);
            Assert.AreEqual(expectedK, actualK);
        }
    }
}
