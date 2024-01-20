using System;

namespace SamuraiEngine
{
    public static class SamuraiExtensions
    {

        public static int AttackDiceCap(this BalanceLevel level)
        {
            switch (level)
            {
                case BalanceLevel.Fallen:
                    return 1;
                case BalanceLevel.Imbalanced:
                    return 2;
                case BalanceLevel.Standing:
                    return 2;
                case BalanceLevel.Balanced:
                    return 3;
                case BalanceLevel.Sturdy:
                    return 3;
                default:
                    throw new System.NotSupportedException();
            }
        }

        public static IMovementSpec MovementSpec(this MovementType movement)
        {
            switch (movement)
            {
                case MovementType.Backroll:
                    return new BackRoll();
                case MovementType.Recover:
                    return new Recover();
                case MovementType.Advance:
                    return new Advance();
                case MovementType.Lunge:
                    return new Lunge();
                case MovementType.Bulwark:
                    return new Bulwark();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}