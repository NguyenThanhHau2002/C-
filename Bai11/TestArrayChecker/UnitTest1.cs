using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bai11;
using System.Linq;
using System.Diagnostics;
namespace TestArrayChecker
{
    [TestClass]
    public class UnitTest1
    {

        
        public TestContext TestContext { get; set; }
     
        [TestMethod] //test
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestBai11()
        {
            string arrayStr = TestContext.DataRow[0].ToString();
    
            bool expectedResult = bool.Parse(TestContext.DataRow[1].ToString());

            int[] a = string.IsNullOrWhiteSpace(arrayStr) ? new int[0] : arrayStr.Split(',').Select(int.Parse).ToArray();

           

            bool result = MangDX.IsSymmetry(a, a.Length);

            Assert.AreEqual(expectedResult, result, "The symmetry check result is incorrect.");
        }
    }
   }

