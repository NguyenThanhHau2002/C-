using Bai3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TetsChuyenDoi
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]

        public void TestMethod1()
        {

            int val = int.Parse(TestContext.DataRow[0].ToString());
            int coso = int.Parse(TestContext.DataRow[1].ToString());
            string expected = TestContext.DataRow[2].ToString();


            string result = ChuyenDoi.Convert(val, coso);

            Assert.AreEqual(expected, result);

        }
    }
}
