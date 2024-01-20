namespace SamuraiEngine
{
    public interface IMovementSpec
    {
        int PositionChange { get; }

        int BalanceChange(PlayerMovementContext ctx);

        int AttackDice { get; }

        int DefenceDice { get; }

        MovementType MovementType { get; }
    }
}