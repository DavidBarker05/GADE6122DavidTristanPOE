namespace GADE6122DavidTristanPOE
{
    //Q2.1
    //Class Position created for storing x and y coordinates for a singular tile on the map 
    internal class Position
    {
        private int positionX;
        private int positionY;

        //constructor accepting x and y integer parameters
        public Position(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
        }

        //properties for x and y coordinates allowing access and modification of backing fields 
        public int PositionX { get { return positionX; } }

        public int PositionY { get { return positionY; } }

    }
}
