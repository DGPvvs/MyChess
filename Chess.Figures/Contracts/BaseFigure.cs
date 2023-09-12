namespace Chess.Figures.Contracts
{
    using Chess.Common.Enums;

    public abstract class BaseFigure : IFigure
    {
        protected BaseFigure(ChessColor color)
        {
            Color = color;
        }

        public ChessColor Color { get; init; }
    }
}
