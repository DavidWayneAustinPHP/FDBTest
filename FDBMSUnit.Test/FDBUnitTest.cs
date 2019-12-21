using Microsoft.VisualStudio.TestTools.UnitTesting;
using FDBTest;

namespace FDBMSUnit.Test
{
    [TestClass]
    public class FDBUnitTest
    {
        [TestMethod]
        public void TestAddingSomeNumbers()
        {
            // Setup variables for tests
            int expected1 = 11;
            DatainfoME myTest = new DatainfoME();
            Pig myPig = new Pig();

            // Get Actual values
            int actual = 11;

            //Asset tests and produce results
            Assert.AreEqual(expected1, actual);
        }
        [TestMethod]
        public void TestAddingSomeNumbers1()
        {
            // Setup variables for tests
            int expected2 = 8;
            DatainfoME myTest = new DatainfoME();
            Pig myPig = new Pig();

            // Get Actual values
            int actual2 = myTest.addForeignValues(3, 5);

            //Asset tests and produce results
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]
        public void TestAddingSomeNumbers2()
        {
            // Setup variables for tests

            int expected3 = 12;
            DatainfoME myTest = new DatainfoME();
            Pig myPig = new Pig();

            // Get Actual values
            int actual3 = myTest.addValues();

            //Asset tests and produce results
            Assert.AreEqual(expected3, actual3);
        }
    }
}
