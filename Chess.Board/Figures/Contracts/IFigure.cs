namespace Chess.Board.Figures.Contracts
{
    using Chess.Board.Moves.Contracts;
    using Chess.Common.Enums;

    public interface IFigure
    {
        public ChessColor Color { get; init; }

        public ICollection<IMoves> Move(IMovementStrategy movementStrategy, FigureEnum figure);
    }
}
