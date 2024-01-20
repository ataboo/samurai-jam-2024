using System;
using System.Linq;

namespace SamuraiEngine {
    public static class LevelStateService {
        public static LevelState CreateLevel() {
            var state = new LevelState {
                player1State = new PlayerState {
                    balance = BalanceLevel.Standing,
                    heading = Heading.Right,
                    health = Constants.StartingHealth,
                    position = 2,
                },
                player2State = new PlayerState {
                    balance = BalanceLevel.Standing,
                    heading = Heading.Left,
                    health = Constants.StartingHealth,
                    position = 4,
                },
                rounds = new Round[]{},
                winner = null,
            };

            StartNewRound(state);

            return state;
        }

        public static void StartNewRound(LevelState state) {
            var latestRound = LatestRound(state);

            if(latestRound != null && latestRound.currentPhase != RoundPhase.Done) {
                throw new InvalidOperationException("Cannot start a round until the last one is done.");
            }

            var newRound = new Round() {
                id = state.rounds.Length,
                buffCount = new Tuple<int, int>(0, 0),
                currentPhase = RoundPhase.SelectingMovement,
                dicePairs = new DicePair[]{},
                p1StartingState = state.player1State.Clone(),
                p2StartingState = state.player2State.Clone(),
                p1Movement = null,
                p2Movement = null,
                p1EndingState = null,
                p2EndingState = null,
            };

            state.rounds = state.rounds.Append(newRound).ToArray();
        }

        private static Round LatestRound(LevelState state) {
            return state.rounds.LastOrDefault();
        }
    }
}