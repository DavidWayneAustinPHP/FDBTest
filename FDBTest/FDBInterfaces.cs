namespace FDBTest
{
    public interface FDBMazeGame
    {
        bool drawMaze();
        int startAndRunGame(int gameScore);
        int mazeGameScore(int gameScore);
        bool movePlayer();
        bool checkHitMines();
        bool checkIfWonGame();
    }
}