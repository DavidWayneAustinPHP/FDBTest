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
            FDBMazeGame.drawMaze();

            // Set mines and starting points for game
            FDBMazeGame.setMines();
            Console.WriteLine();
            Console.WriteLine("Press any key to start the game.");
            Console.WriteLine("Use cursor key to control your character and reach the top of the maze.");
            Console.WriteLine("Try avoid the mines on the way");

            // Start Game and check record score and check if won
            FDBMazeGame.startAndRunGame(startingScore);

            // Game ends write to the screen the player result and score
            Console.ReadLine();
            Console.WriteLine("Thank you for trying the game has ended");
            Console.WriteLine("Your score was: ",  FDBMazeGame.mazeGameScore(startingScore));
            Console.WriteLine("Please press any key to close the game");
            Console.ReadKey();

        }
    }
}
