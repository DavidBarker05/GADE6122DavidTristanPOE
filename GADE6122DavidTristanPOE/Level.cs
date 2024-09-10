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
            Wall
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
                case TileType.Wall: 
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
                    CreateTile(TileType.EmptyTile, x, y);
                }
            }
            //Q3.2
            Position position;
            for (int y = 0; y < height; y++)
            {
                position = new Position(0, y);
                CreateTile(TileType.Wall, position);
                position = new Position(width - 1, y);
                CreateTile(TileType.Wall, position);
            }
            for (int x = 0; width > 0; x++)
            {
                position = new Position(0, x);
                CreateTile(TileType.Wall, position);
                position = new Position(height - 1, x);
                CreateTile(TileType.Wall, position);
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
