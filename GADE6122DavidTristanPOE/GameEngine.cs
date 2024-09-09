using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122DavidTristanPOE
{
    internal class GameEngine
    {
        private int levelAmt;
        private int numLevel;

        private Random rnd = new Random();

        const int minSize = 10;
        const int maxSize = 20;


        public GameEngine(int levelAmt)
        {
            this.levelAmt = 0;
            //?
            return;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        //?
        //private int GameEngine { get { return (int)levelAmt; } }
    }
}
