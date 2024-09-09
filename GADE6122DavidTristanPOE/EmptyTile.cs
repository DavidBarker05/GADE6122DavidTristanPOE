namespace GADE6122DavidTristanPOE
{
    //Q2.3
    internal class EmptyTile : Tile
    {

        public EmptyTile(Position position) : base(position)
        {
        }

        public override char Display => '.';

    }
}
