using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bai1;

namespace Bai1.Tests
{
    [TestClass]
    public class ChuoiTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
      
        public void TestChuoi()
        {
     
            string inputString = TestContext.DataRow[0].ToString();
            int expectedIndex = int.Parse(TestContext.DataRow[1].ToString());
            Chuoi chuoi = new Chuoi();

         
            int actualIndex = chuoi.SIndex(inputString);

         
            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
