namespace SamuraiEngine
{
    public class Recover : IMovementSpec
    {
        public int PositionChange => 0;

        public int AttackDice => 1;

        public int DefenceDice => 1;

        public int BalanceChange(PlayerMovementContext ctx)
        {
            return 1;
        }

        public MovementType MovementType => MovementType.Recover;
    }
}