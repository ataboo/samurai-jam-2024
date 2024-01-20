namespace SamuraiEngine
{
    public class Lunge : IMovementSpec
    {
        public int PositionChange => 2;

        public int AttackDice => 2;

        public int DefenceDice => 0;

        public int BalanceChange(PlayerMovementContext ctx)
        {
            return ctx.canCompleteMove ? 0 : -1;
        }

        public MovementType MovementType => MovementType.Lunge;
    }
}