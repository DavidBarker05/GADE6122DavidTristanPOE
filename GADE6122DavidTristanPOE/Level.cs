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

        public enum TileType
        {
            EmptyTile,
            WallTile
        }

        private Tile[,] tiles;
        private int width, height;

        public Tile[,] Tiles { get {  return tiles; } set { tiles = value; } }

        public Level(int width, int height)
        {
            this.width = width;
            this.height = height;
            tiles = new Tile[width, height];
            InitialiseTiles();
        }

        private Tile CreateTile(TileType tileType, Position position)
        {
            Tile tile = null;

            switch (tileType)
            {
                case TileType.EmptyTile:
                    tile = new EmptyTile(position);
                    break;
                case TileType.WallTile: 
                    tile = new WallTile(position);
                    break;
            }

            tiles[position.X, position.Y] = tile;

            return tile;
        }

        private Tile CreateTile(TileType tileType, int x, int y)
        {
            return CreateTile(tileType, new Position(x, y));
        }

        private void InitialiseTiles()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (y == 0 || x == 0 || y == height - 1 || x == width - 1) CreateTile(TileType.WallTile, x, y);
                    else CreateTile(TileType.EmptyTile, x, y);
                }
            }
        }

        public override string ToString()
        {
            string level = "";

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    level += tiles[x, y].Display;
                }
                level += "\n";
            }

            return level;
        }
    }
}
