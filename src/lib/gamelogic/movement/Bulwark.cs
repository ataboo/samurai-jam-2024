namespace SamuraiEngine
{
    public class Bulwark : IMovementSpec
    {
        public int PositionChange => 0;

        public int AttackDice => 2;

        public int DefenceDice => 1;

        public int BalanceChange(PlayerMovementContext ctx)
        {
            return ctx.hasCombatPhase ? 0 : -1;
        }

        public MovementType MovementType => MovementType.Bulwark;
    }
}