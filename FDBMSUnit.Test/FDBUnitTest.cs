using Microsoft.VisualStudio.TestTools.UnitTesting;
using FDBTest;
using System.Collections.Generic;

namespace FDBMSUnit.Test
{
    [TestClass]
    public class FDBUnitTest
    {
        [TestMethod]
        public void TestFDBMazeStartingScore()
        {
            // Setup variables for tests
            var expectedMineLocation = new List<MineLocation>();
            DatainfoGame expectedFDBMazeGame = new DatainfoGame();
            MazeGameData expectedGameData = new MazeGameData();
            int expected = 0;

            // Get Actual values - Need to build test case
            int actual = expectedGameData.startingScore;

            //Asset tests and produce results
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFDBStartingPositionX()
        {
            // Setup variables for tests
            var expectedMineLocation = new List<MineLocation>();
            DatainfoGame expectedFDBMazeGame = new DatainfoGame();
            MazeGameData expectedGameData = new MazeGameData();
            int expected = 8;

            // Get Actual values - Need to build test case
            int actual = expectedGameData.playerPosX;

            //Asset tests and produce results
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFDBStartingPlayerPositionY()
        {
            // Setup variables for tests
            var expectedMineLocation = new List<MineLocation>();
            DatainfoGame expectedFDBMazeGame = new DatainfoGame();
            MazeGameData expectedGameData = new MazeGameData();
            int expected = 8;

            // Get Actual values - Need to build test case
            int actual = expectedGameData.playerPosY;

            //Asset tests and produce results
            Assert.AreEqual(expected, actual);
        }
    }
}
