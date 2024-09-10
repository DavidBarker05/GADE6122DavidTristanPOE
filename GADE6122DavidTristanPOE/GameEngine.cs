using System;

namespace GADE6122DavidTristanPOE
{
    internal class GameEngine
    {
        private Level currentLevel;
        private int levelAmt;
        private Random rnd = new Random();

        const int MIN_SIZE = 10;
        const int MAX_SIZE = 20;

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

        public override string ToString()
        {
            return currentLevel.ToString();
        }
    }
}
