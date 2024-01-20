using System;

namespace SamuraiEngine
{
    public class Round
    {
        public int id;
        
        public RoundPhase currentPhase;

        public PlayerState p1StartingState;

        public PlayerState p2StartingState;

        public MovementType? p1Movement;

        public MovementType? p2Movement;

        public Tuple<int, int> buffCount;

        public DicePair[] dicePairs;

        public PlayerState? p1EndingState;

        public PlayerState? p2EndingState;
    }
}