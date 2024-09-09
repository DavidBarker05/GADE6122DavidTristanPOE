namespace GADE6122DavidTristanPOE
{
    //Q2.3
    internal class EmptyTile : Tile
    {
        public EmptyTile(Position position, string positionType)
            : base(position.X, position.Y)
        {
        }
        public EmptyTile(Position position)
            : base(position.X, position.Y)
        {

        }

        public string positionType { get; set; }


        public override char Display => '.';
    }
}
