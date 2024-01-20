namespace SamuraiEngine
{
    public class Advance : IMovementSpec
    {
        public int PositionChange => 1;

        public int AttackDice => 2;

        public int DefenceDice => 0;

        public int BalanceChange(PlayerMovementContext ctx)
        {
            return 0;
        }

        public MovementType MovementType => MovementType.Advance;
    }
}