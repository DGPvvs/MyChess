namespace Chess.Board.Figures.Contracts
{
    using Chess.Board.Moves.Contracts;
    using Chess.Common.Enums;

    public abstract class BaseFigure : IFigure
    {
        protected BaseFigure(ChessColor color)
        {
            Color = color;
        }

        public ChessColor Color { get; init; }

        public abstract ICollection<IMoves> Move();
    }
}
