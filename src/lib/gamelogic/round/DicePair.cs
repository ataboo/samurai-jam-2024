using System;

namespace SamuraiEngine
{
    public struct DicePair
    {
        public DiceRoll p1Roll;

        public DiceRoll p2Roll;

        public bool saved;

        public Tuple<int, int> Damage()
        {
            if (this.saved)
            {
                return new Tuple<int, int>(0, 0);
            }

            switch (Winner())
            {
                case SamuraiEngine.Winner.Player1:
                    var p2Dmg = p1Roll.isAttack ? p1Roll.value - p2Roll.value : 0;
                    return new Tuple<int, int>(0, p2Dmg);
                case SamuraiEngine.Winner.Player2:
                    var p1Dmg = p2Roll.isAttack ? p2Roll.value - p1Roll.value : 0;
                    return new Tuple<int, int>(p1Dmg, 0);
                case SamuraiEngine.Winner.Tie:
                    return new Tuple<int, int>(0, 0);
                default:
                    throw new NotSupportedException();
            }
        }

        public Winner Winner()
        {
            if (p1Roll.value == p2Roll.value)
            {
                return SamuraiEngine.Winner.Tie;
            }

            return p1Roll.value > p2Roll.value ? SamuraiEngine.Winner.Player1 : SamuraiEngine.Winner.Player2;
        }
    }
}