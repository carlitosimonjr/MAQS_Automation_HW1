using CognizantSoftvision.Maqs.BaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    /// CalcTest test class
    /// </summary>
    [TestClass]
    public class CalcTest : BaseTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [TestMethod]
        public void AdditionTest()
        {
            int numOne = 1;
            int numTwo = 2;

            int sum = numOne + numTwo;
            this.Log.LogMessage("Add Test");
            Assert.AreEqual(3, sum, "Failed");
        }
    }
}
