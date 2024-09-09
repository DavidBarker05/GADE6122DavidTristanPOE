namespace GADE6122DavidTristanPOE
{
    internal abstract class CharacterTile : Tile
    {

        private int hitPoints, maxHitPoints, attackPower;
        private Tile[] vision;

        public bool IsDead { get { return hitPoints == 0; } }

        public CharacterTile(Position position, int hitPoints, int attackPower) : base(position)
        {
            this.hitPoints = hitPoints;
            maxHitPoints = hitPoints;
            this.attackPower = attackPower;
            vision = new Tile[4];
        }

        public void UpdateVision(Level level)
        {
            vision[0] = level.Tiles[X, Y - 1];
            vision[1] = level.Tiles[X + 1, Y];
            vision[2] = level.Tiles[X, Y + 1];
            vision[3] = level.Tiles[X - 1, Y];
        }

        public void TakeDamage(int damage)
        {
            hitPoints -= damage;
            if (hitPoints < 0) hitPoints = 0;
        }

        public void Attack(CharacterTile characterTile)
        {
            characterTile.TakeDamage(attackPower);
        }

    }
}
