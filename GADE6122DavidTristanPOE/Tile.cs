namespace GADE6122DavidTristanPOE
{
    //Q2.2
    internal abstract class Tile
    {
        private int positionType;
        private int positionX, positionY;

        public int PositionX { get { return positionX; } }

        public int PositionY { get { return positionY; } }

        public Tile(int x, int y)
        {
            this.positionX = PositionX;
            this.positionY = PositionX;
        }

        public abstract char Display { get; }


    }
}
