using Microsoft.VisualStudio.TestTools.UnitTesting;
using FDBTest;

namespace FDBMSUnit.Test
{
    [TestClass]
    public class FDBUnitTest
    {
        [TestMethod]
        public void TestMazeDrawCorrectly()
        {
            // Setup variables for tests
            bool mazeDrawCorrectly = true;
            DatainfoGame FDBMazeGame = new DatainfoGame();
            
            // Get Actual values - Need to build test case
            bool actual = FDBMazeGame.drawMaze();

            //Asset tests and produce results
            Assert.AreEqual(mazeDrawCorrectly, actual);
        }
        [TestMethod]
        public void TestMazeStartingScore()
        {
            // Setup variables for tests
            int startScore = 0;
            DatainfoGame FDBMazeGame = new DatainfoGame();
            
            // Get Actual values -  Need to build test case
            int actual2 = FDBMazeGame.mazeGameScore(startScore);

            //Asset tests and produce results
            Assert.AreEqual(startScore, actual2);
        }
        [TestMethod]
        public void TestMovePlayer()
        {
            // Setup variables for tests
            bool expected = true;
            DatainfoGame FDBMazeGame = new DatainfoGame();


            // Get Actual values - Need to build test case
            bool actual3 = FDBMazeGame.movePlayer();

            //Asset tests and produce results
            Assert.AreEqual(expected, actual3);
        }
        [TestMethod]
        public void TestCheckHitMines()
        {
            // Setup variables for tests
            bool expected = true;
            DatainfoGame FDBMazeGame = new DatainfoGame();


            // Get Actual values - Need to build test case
            bool actual3 = FDBMazeGame.checkHitMines();

            //Asset tests and produce results
            Assert.AreEqual(expected, actual3);
        }
        [TestMethod]
        public void TestcheckIfWonGame()
        {
            // Setup variables for tests
            bool expected = true;
            DatainfoGame FDBMazeGame = new DatainfoGame();


            // Get Actual values - Need to build test case
            bool actual3 = FDBMazeGame.checkIfWonGame();

            //Asset tests and produce results
            Assert.AreEqual(expected, actual3);
        }
        [TestMethod]
        public void TestStartAndRunGame()
        {
            // Setup variables for tests
            int expected = 0;
            DatainfoGame FDBMazeGame = new DatainfoGame();

            // Get Actual values - Need to build test case
            int actual3 = FDBMazeGame.startAndRunGame(expected);

            //Asset tests and produce results
            Assert.AreEqual(expected, actual3);
        }
    }
}
