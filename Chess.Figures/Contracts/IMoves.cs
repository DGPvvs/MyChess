namespace Class.Moves.Contracts
{
    using Chess.Figures.Contracts;

    public interface IMoves
    {
        public void ValidateMove(IFigure figure, IBoard board);
    }
}
