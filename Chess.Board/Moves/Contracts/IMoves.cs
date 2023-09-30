namespace Chess.Board.Moves.Contracts
{
    using Chess.Board.Contracts;
    using Chess.Board.Figures.Contracts;

    public interface IMoves
    {
        public void ValidateMove(IFigure figure, IBoard board);
    }
}
