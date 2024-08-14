using Bai13;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HexToDecConverterTests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void Convert_ValidAndInvalidHexInputs_ReturnsExpectedResults()
        {
            var hex = TestContext.DataRow[0].ToString();
            var expected = TestContext.DataRow[1].ToString();
            var converter = new HexToDecConverter();
            var result = converter.Convert(hex);

            Assert.AreEqual(expected, result);
        }
    }
}
