using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122DavidTristanPOE
{
    //Q2.4
    internal class Level
    {
        static string[] Tile = { "Width", "Height" };

        int resultX = Int32.Parse(Tile[0]);
        int resultY = Int32.Parse(Tile[1]);

        int positionX, positionY;

        public Level(int reslutX, int resultY)
        {
            this.resultX = positionX;
            this.resultY = positionY;

            positionX = 0;
            positionY = 0;

        }
        enum TileType
        {
            EmptyTile,
        }

        private void CreateTile(int TileType, int Position)
        {
            Object tile = new Object();

            switch (TileType)
            {
                case int EmptyTile:
                    break;
            }

            //int EmpryTile = Tile[];

            return;
        }

        static void InitialiseTiles()
        {
            //?
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
