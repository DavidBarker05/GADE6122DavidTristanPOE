namespace GADE6122DavidTristanPOE
{
    //Q2.2
    internal abstract class Tile
    {
        private Position position;

        public int X { get { return position.X; } }
        public int Y { get { return position.Y; } }

        public Tile(Position position)
        {
            this.position = position;
        }

        public abstract char Display { get; }
    }
}
