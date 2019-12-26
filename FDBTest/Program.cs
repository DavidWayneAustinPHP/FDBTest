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
            int mine1PosX = 4, mine1PosY = 5;     // Needs to be a random number of mines
            int mine2PosX = 7, mine2PosY = 3;     // Needs to be a random number of mines
            int maxNumberMinesHit = 2;
            int numberMinesCollided = 0;
            int mazeLength = 8;
            int mazeHeight = 8;
            char mazePlayer = '*';
            char mazeSpace = '-';
            char mazeMine = '#';     // Needs to be a random number of mines
            // int finishPosX = 8;
            int finishPosY = 1;     // If player reaches botton most are then game ends

            // Game Headings and intructions
            Console.WriteLine();
            Console.WriteLine("Press any key to start the game.");
            Console.WriteLine("Use cursor key to control your character and reach the top of the maze.");
            Console.WriteLine("Try avoid the mines on the way");
            Console.WriteLine();

            while (playerPosY > finishPosY && numberMinesCollided < maxNumberMinesHit)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                if ((keyPressed.Key == ConsoleKey.U && playerPosY != 1)|| (keyPressed.Key == ConsoleKey.D && playerPosY != mazeHeight))
                {
                    playerPosY += (keyPressed.Key == ConsoleKey.D) ? 1 : -1;
                    ++startingScore;

                    if (playerPosX == mine1PosX && playerPosY == mine1PosY) ++numberMinesCollided;
                    if (playerPosX == mine2PosX && playerPosY == mine2PosY) ++numberMinesCollided;
                } 
                else if ((keyPressed.Key == ConsoleKey.L || playerPosX != 1) || (keyPressed.Key == ConsoleKey.R && playerPosX != mazeLength))
                {
                    playerPosX += (keyPressed.Key == ConsoleKey.R) ? 1 : -1;
                    if (playerPosX > 8) playerPosX = 8;
                    if (playerPosX < 1) playerPosX = 1;
                    ++startingScore;

                    if (playerPosX == mine1PosX && playerPosY == mine1PosY) ++numberMinesCollided;
                    if (playerPosX == mine2PosX && playerPosY == mine2PosY) ++numberMinesCollided;
                }

                Console.Clear();

                for (int y = 1; y <= mazeHeight; ++y)
                {
                    for (int x = 1; x <= mazeLength; ++x)
                    {
                        if (x == playerPosX && y == playerPosY) Console.Write(mazePlayer);
                        else if (x == mine1PosX && y == mine1PosY) Console.Write(mazeMine);
                        else if (x == mine2PosX && y == mine2PosY) Console.Write(mazeMine);
                        else Console.Write(mazeSpace);
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
            Console.WriteLine("Please press any key to close the game");
            Console.ReadKey();
        }
    }
}
