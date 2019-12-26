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
            // Declare variable
            DatainfoGame FDBMazeGame = new DatainfoGame();
            int startingScore = 0;

            // Draw Maze
            // FDBMazeGame.drawMaze();  // Turn off method - needs updating

            // Building the game once code written then add to the classes, interfaces and build the tests
            int playerPosX = 8;
            int playerPosY = 8;
            int maxNumberMinesHit = 2;
            int numberMinesCollided = 0;
            int mazeLength = 8;
            int mazeHeight = 8;
            char mazePlayer = '*';
            char mazeSpace = '-';
            char mazeMine = '#';    // Needs to be a random number of mines
            int finishPosY = 1;     // If player reaches botton most are then game ends

            // Game Headings and intructions
            Console.WriteLine();
            Console.WriteLine("Press any key to start the game.");
            Console.WriteLine("Use cursor key to control your character and reach the top of the maze.");
            Console.WriteLine("Try avoid the mines on the way");
            Console.WriteLine();

            // Create randon number of mines and obtain positions for placement in the maze
            var allMineLocations = FDBMazeGame.setMines();

            // Run game and rebuild the maze on key pressed
            while (playerPosY > finishPosY && numberMinesCollided < maxNumberMinesHit)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                if ((keyPressed.Key == ConsoleKey.U && playerPosY != 1)|| (keyPressed.Key == ConsoleKey.D && playerPosY != mazeHeight))
                {
                    playerPosY += (keyPressed.Key == ConsoleKey.D) ? 1 : -1;
                    ++startingScore;

                    foreach (var m in allMineLocations)
                    {
                        if (playerPosX == m.minePositionX && playerPosY == m.minePositionY) ++numberMinesCollided;
                    }
                } 
                else if ((keyPressed.Key == ConsoleKey.L || playerPosX != 1) || (keyPressed.Key == ConsoleKey.R && playerPosX != mazeLength))
                {
                    playerPosX += (keyPressed.Key == ConsoleKey.R) ? 1 : -1;
                    if (playerPosX > 8) playerPosX = 8;
                    if (playerPosX < 1) playerPosX = 1;
                    ++startingScore;

                    foreach (var m in allMineLocations)
                    {
                        if (playerPosX == m.minePositionX && playerPosY == m.minePositionY) ++numberMinesCollided;
                    }
                }

                Console.Clear();

                for (int y = 1; y <= mazeHeight; ++y)
                {
                    for (int x = 1; x <= mazeLength; ++x)
                    {
                        if (x == playerPosX && y == playerPosY) Console.Write(mazePlayer);
                        else 
                        {
                            bool placemine = false;
                            foreach (var m in allMineLocations)
                            {
                                if (x == m.minePositionX && y == m.minePositionY) placemine = true;
                            }
                            if (placemine) Console.Write(mazeMine);
                            else Console.Write(mazeSpace);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Current Player position in the Maze: " + playerPosX + ", " + playerPosY);
            }

            // Start Game and check record score and check if won
            FDBMazeGame.startAndRunGame(startingScore);

            // Game ends write to the screen the player result and score
            Console.WriteLine("Thank you for trying the game has ended");
            if (numberMinesCollided >= maxNumberMinesHit) Console.WriteLine("Game has ended without reaching the top, too many mines hit.");
            Console.WriteLine("You have taken " + startingScore + " moves to complete the game");
            Console.WriteLine("And hit " + numberMinesCollided + " mines along the way");
            Console.WriteLine("Number of mines in the maze " + allMineLocations.Count());
            Console.WriteLine("Please press any key to close the game");
            Console.ReadKey();
        }
    }
}
