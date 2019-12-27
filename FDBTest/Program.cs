using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDBTest;

namespace FDBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            MazeGameData gameData = new MazeGameData();

            // Game Headings and intructions
            Console.WriteLine();
            Console.WriteLine("Press any key to start the game.");
            Console.WriteLine("Use cursor key to control your character and reach the top of the maze.");
            Console.WriteLine("Try avoid the mines on the way");
            Console.WriteLine();

            // Create randon number of mines and obtain positions for placement in the maze
            DatainfoGame FDBMazeGame = new DatainfoGame();
            var allMineLocations = FDBMazeGame.setMines();

            // Run game and rebuild the maze on key pressed
            while (gameData.playerPosY > gameData.finishPosY && gameData.numberMinesCollided < gameData.maxNumberMinesHit)
            {
                // Game starts on key press
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                // Move player in the maze determined by the key pressed, calculate score and check is collide with mine
                if ((keyPressed.Key == ConsoleKey.U && gameData.playerPosY != 1)|| (keyPressed.Key == ConsoleKey.D && gameData.playerPosY != gameData.mazeHeight))
                {
                    gameData.playerPosY += (keyPressed.Key == ConsoleKey.D) ? 1 : -1;
                    ++gameData.startingScore;

                    foreach (var m in allMineLocations)
                    {
                        if (gameData.playerPosX == m.minePositionX && gameData.playerPosY == m.minePositionY) ++gameData.numberMinesCollided;
                    }
                } 
                else if ((keyPressed.Key == ConsoleKey.L || gameData.playerPosX != 1) || (keyPressed.Key == ConsoleKey.R && gameData.playerPosX != gameData.mazeLength))
                {
                    gameData.playerPosX += (keyPressed.Key == ConsoleKey.R) ? 1 : -1;
                    if (gameData.playerPosX > 8) gameData.playerPosX = 8;
                    if (gameData.playerPosX < 1) gameData.playerPosX = 1;
                    ++gameData.startingScore;

                    foreach (var m in allMineLocations)
                    {
                        if (gameData.playerPosX == m.minePositionX && gameData.playerPosY == m.minePositionY) ++gameData.numberMinesCollided;
                    }
                }

                Console.Clear();

                // Rebuild the maze on the screen after keypressed
                for (int y = 1; y <= gameData.mazeHeight; ++y)
                {
                    for (int x = 1; x <= gameData.mazeLength; ++x)
                    {
                        if (x == gameData.playerPosX && y == gameData.playerPosY) Console.Write(gameData.mazePlayer);
                        else 
                        {
                            bool placemine = false;
                            foreach (var m in allMineLocations)
                            {
                                if (x == m.minePositionX && y == m.minePositionY) placemine = true;
                            }
                            if (placemine) Console.Write(gameData.mazeMine);
                            else Console.Write(gameData.mazeSpace);
                        }
                    }
                    Console.WriteLine();
                }
                // Write out the current position the player is in the maze
                Console.WriteLine();
                Console.WriteLine("Current Player position in the Maze: " + gameData.playerPosX + ", " + gameData.playerPosY);
            }

            // Game ends write to the screen the player result and score
            Console.WriteLine("Thank you for trying the game has ended");

            // Check is player has hit 2 mines, if so then write out that player has hit two mines
            if (gameData.numberMinesCollided >= gameData.maxNumberMinesHit) Console.WriteLine("Game has ended without reaching the top, too many mines hit.");
            Console.WriteLine("You have taken " + gameData.startingScore + " moves to complete the game");
            Console.WriteLine("And hit " + gameData.numberMinesCollided + " mines along the way");
            Console.WriteLine("Number of mines in the maze " + allMineLocations.Count());
            Console.WriteLine("Please press any key to close the game");
            Console.ReadKey();
        }
    }
}
