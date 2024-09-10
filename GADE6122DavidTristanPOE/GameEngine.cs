using System;

namespace GADE6122DavidTristanPOE
{
    internal class GameEngine
    {
        public enum Direction
        {
            Up = 0,
            Right = 1,
            Down = 2,
            Left = 3,
            None = 4
        }

        public enum GameState
        {
            InProgress,
            Complete,
            GameOver
        }

        private Level currentLevel;
        private int levelAmt;
        private Random rnd = new Random();
        private GameState gameState = GameState.InProgress;
        private int currentLevelNumber = 1;

        const int MIN_SIZE = 10;
        const int MAX_SIZE = 20;

        public int LevelAmt { get { return levelAmt; } }
        public int CurrentLevelNumber { get { return currentLevelNumber; } }

        public GameEngine(int levelAmt)
        {
            this.levelAmt = levelAmt;
            int width = rnd.Next(MIN_SIZE, MAX_SIZE + 1);
            int height = rnd.Next(MIN_SIZE, MAX_SIZE + 1);
            currentLevel = new Level(width, height);
        }

        private bool MoveHero(Direction direction)
        {
            HeroTile heroTile = currentLevel.HeroTile;
            bool success = false;
            if ((int)direction < 4)
            {
                if (heroTile.Vision[(int)direction] is ExitTile)
                {
                    if (currentLevelNumber == levelAmt) gameState = GameState.Complete;
                    else NextLevel();
                    return currentLevelNumber < levelAmt;
                }
                success = heroTile.Vision[(int)direction] is EmptyTile;
                if (success)
                {
                    currentLevel.SwopTiles(heroTile, heroTile.Vision[(int)direction]);
                    heroTile.UpdateVision(currentLevel);
                }
            }
            return success;
        }

        public void TriggerMovement(Direction direction)
        {
            MoveHero(direction);
        }

        public void NextLevel()
        {
            currentLevelNumber++;
            HeroTile heroTile = currentLevel.HeroTile;
            int width = rnd.Next(MIN_SIZE, MAX_SIZE + 1);
            int height = rnd.Next(MIN_SIZE, MAX_SIZE + 1);
            currentLevel = new Level(width, height, heroTile);
        }

        public override string ToString()
        {
            return gameState == GameState.Complete ? "YOU WIN!!!" : currentLevel.ToString();
        }
    }
}
