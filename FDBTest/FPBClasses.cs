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

    public class MazeGameData : FDBMazeVariables
    {
        // Declare variables
        public int startingScore = 0;
        public int playerPosX = 8;
        public int playerPosY = 8;
        public int maxNumberMinesHit = 2;
        public int numberMinesCollided = 0;
        public int mazeLength = 8;
        public int mazeHeight = 8;
        public char mazePlayer = '*';
        public char mazeSpace = '-';
        public char mazeMine = '#';    
        public int finishPosY = 1;     // If player reaches top most area of the maze game ends
    }

    public class MineLocation : FDBMinesClass
    {
        // Declare mine location variables
        public int minePositionX;
        public int minePositionY;
    }

    public class  DatainfoGame : FDBMazeSetMines
    {
        public List<MineLocation> setMines()
        {
            Random randm = new Random();
            var mineLocationsAll = new List<MineLocation>();
            int numberOfMines = randm.Next(1, 20);

            for (int i=0; i < numberOfMines; i++)
            {
                mineLocationsAll.Add(new MineLocation()
                {
                    minePositionX = randm.Next(1, 8),
                    minePositionY = randm.Next(1, 8)
                });
            }
            return mineLocationsAll;
        }
    }
}
