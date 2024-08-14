using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Bai12;

namespace QuickSortTests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestQuickSort()
        {
            string arrayStr = TestContext.DataRow[0].ToString();
            string expectedArrayStr = TestContext.DataRow[1].ToString();

            int[] array = string.IsNullOrWhiteSpace(arrayStr) ? new int[0] : arrayStr.Split(',').Select(int.Parse).ToArray();
            int[] expectedArray = string.IsNullOrWhiteSpace(expectedArrayStr) ? new int[0] : expectedArrayStr.Split(',').Select(int.Parse).ToArray();

            QuickSort.quickSort(array, 0, array.Length - 1);

            CollectionAssert.AreEqual(expectedArray, array, "The quick sort result is incorrect.");

        }
    }
}
