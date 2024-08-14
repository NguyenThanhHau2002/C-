using Bai14;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CallCostCalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestCalculateTotalCost()
        {
            int startHour = Convert.ToInt32(TestContext.DataRow[0]);
            int startMinute = Convert.ToInt32(TestContext.DataRow[1]);
            int durationMinutes = Convert.ToInt32(TestContext.DataRow[2]);
            decimal expectedCost = Convert.ToDecimal(TestContext.DataRow[3]);

            decimal actualCost = CallCostCalculator.CalculateTotalCost(startHour, startMinute, durationMinutes);

            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
