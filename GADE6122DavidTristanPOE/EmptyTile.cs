namespace GADE6122DavidTristanPOE
{
    //Q2.3
    internal class EmptyTile : Tile
    {
        public EmptyTile(Position position, string positionType)
            : base(position.PositionX, position.PositionY)
        {
        }
        public EmptyTile(Position position)
            : base(position.PositionX, position.PositionY)
        {

        }

        public string positionType { get; set; }


        public override char Display => '.';
    }
}
