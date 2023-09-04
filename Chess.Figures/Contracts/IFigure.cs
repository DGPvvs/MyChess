namespace Chess.Figures.Contracts
{
    using Chess.Common.Enums;

    public interface IFigure
    {
        public ChessColor Color { get; init; }
    }
}
