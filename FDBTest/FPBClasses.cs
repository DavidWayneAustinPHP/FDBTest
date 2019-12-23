using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBTest
{
    class FPBClasses
    {
    }

    public class  DatainfoGame : FDBMazeGame
    {
        // Declare starting variables
        private int startPositionX = 0;
        private int startPositionY = 0;
        private int numberOfMines = 5;
        private int maxNumerMinesHit = 2;
        private int finishPositionX = 8;
        private int finishPositionY = 8;
        private int gameScore = 0;

        public bool drawMaze()
        {
            int i, j, remainder;
            for (i = 1; i <= 8; i++)
            {
                if (i % 2 == 0) { remainder = 1; }
                else { remainder = 0; }
                for (j = 1; j <= 8; j++)
                {
                    if (j % 2 == remainder)
                    { Console.Write("O"); }
                    else { Console.Write("X"); }
                }
                Console.WriteLine();
            }
            return true;
        }

        public int startAndRunGame(int gameScore)
        {
            return gameScore;
        }

        public int mazeGameScore(int gameScore)
        {
            return gameScore;
        }

        public bool movePlayer()
        {
            return true;
        }

        public bool setMines()
        {
            return true;
        }

        public bool checkHitMines()
        {
            return true;
        }

        public bool checkIfWonGame()
        {
            return true;
        }
    }
}
