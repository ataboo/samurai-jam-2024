namespace SamuraiEngine
{
    public struct PlayerState
    {
        public int health;

        public int position;

        public BalanceLevel balance;

        public Heading heading;

        public PlayerState Clone()
        {
            return new PlayerState
            {
                health = this.health,
                balance = this.balance,
                heading = this.heading,
                position = this.position,
            };
        }
    }
}