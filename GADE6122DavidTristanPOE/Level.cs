using System;

namespace GADE6122DavidTristanPOE
{
    //Q2.4
    internal class Level
    {
        public enum TileType
        {
            EmptyTile,
            WallTile,
            HeroTile
        }

        private Tile[,] tiles;
        private int width, height;
        private HeroTile heroTile;

        public HeroTile HeroTile { get { return heroTile; } }

        public Tile[,] Tiles { get {  return tiles; } set { tiles = value; } }

        public Level(int width, int height, HeroTile heroTile = null)
        {
            this.width = width;
            this.height = height;
            tiles = new Tile[width, height];
            InitialiseTiles();
            Position heroPos = GetRandomEmptyPosition();
            if (heroTile == null) this.heroTile = (HeroTile)CreateTile(TileType.HeroTile, heroPos);
            else
            {
                tiles[heroPos.X, heroPos.Y] = heroTile;
                this.heroTile = heroTile;
            }
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
                case TileType.HeroTile:
                    tile = new HeroTile(position);
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

        private Position GetRandomEmptyPosition()
        {
            Random r = new Random();
            int x, y;
            do
            {
                x = r.Next(0, width);
                y = r.Next(0, height);
            } while (!(tiles[x, y] is EmptyTile));
            return new Position(x, y);
        }

        public void SwopTiles(Tile tile1, Tile tile2)
        {
            Tile _tile = tiles[tile1.X, tile1.Y];
            Position _position = tile1.Position;
            tiles[tile1.X, tile1.Y] = tiles[tile2.X, tile2.Y];
            tile1.Position = tile2.Position;
            tiles[tile2.X, tile2.Y] = _tile;
            tile2.Position = _position;
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
