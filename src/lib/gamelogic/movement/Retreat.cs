namespace SamuraiEngine
{
    public class Retreat : IMovementSpec
    {
        public int PositionChange => -1;

        public int AttackDice => 0;

        public int DefenceDice => 3;

        public int BalanceChange(PlayerMovementContext ctx)
        {
            return 1;
        }

        public MovementType MovementType => MovementType.Retreat;
    }
}