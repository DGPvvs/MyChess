namespace Chess.Board.Moves.Contracts
{
    using Chess.Common.Enums;

    public interface IMovementStrategy
    {
        public IList<IMoves> GetMoves(FigureEnum figure);
    }
}
