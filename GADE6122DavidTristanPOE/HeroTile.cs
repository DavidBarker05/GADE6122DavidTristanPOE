namespace GADE6122DavidTristanPOE
{
    internal class HeroTile : CharacterTile
    {

        public HeroTile(Position position) : base(position, 40, 5)
        {
        }

        public override char Display => IsDead ? 'x' : '▼';

    }
}
