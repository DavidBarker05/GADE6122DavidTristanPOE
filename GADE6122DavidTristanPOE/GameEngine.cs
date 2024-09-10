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

        public override string ToString()
        {
            return currentLevel.ToString();
        }
    }
}
