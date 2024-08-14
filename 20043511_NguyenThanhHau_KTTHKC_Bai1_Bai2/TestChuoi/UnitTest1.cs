using KTTHKC_Bai1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestChuoi
{
    [TestClass]
    public class UnitTest1
    {
       
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            string s = TestContext.DataRow[0].ToString();
            string s1 = TestContext.DataRow[1].ToString();
            int expected = int.Parse(TestContext.DataRow[2].ToString());

            Chuoi chuoi = new Chuoi();
            int actual = chuoi.String(s, s1);

            Assert.AreEqual(expected, actual);

        }
    }
}
