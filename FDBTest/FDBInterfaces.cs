namespace FDBTest
{
    public interface FDBMazeGame
    {
        bool drawMaze();
        int startAndRunGame(int gameScore);
        int mazeGameScore(int gameScore);
        bool movePlayer();
        bool setMines();
        bool checkHitMines();
        bool checkIfWonGame();
    }
}