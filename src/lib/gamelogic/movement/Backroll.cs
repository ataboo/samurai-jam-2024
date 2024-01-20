using System;

namespace SamuraiEngine
{
    public class BackRoll : IMovementSpec
    {
        public int PositionChange => -2;

        public int AttackDice => throw new NotImplementedException();

        public int DefenceDice => throw new NotImplementedException();

        public int BalanceChange(PlayerMovementContext ctx)
        {
            return ctx.hasCombatPhase ? 0 : 1;
        }

        public MovementType MovementType => MovementType.Backroll;
    }
}