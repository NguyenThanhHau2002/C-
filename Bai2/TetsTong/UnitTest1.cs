using Bai2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bai2;

namespace TetsTong
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            int n = int.Parse(TestContext.DataRow[0].ToString());
            int expectedIndex = int.Parse(TestContext.DataRow[1].ToString());
            int result = Tong.TinhTong(n);
            Assert.AreEqual(expectedIndex, result);
        }
    }
}
