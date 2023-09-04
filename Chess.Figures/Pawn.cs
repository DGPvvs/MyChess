namespace Chess.Figures
{
    using Chess.Common.Enums;
    using Chess.Figures.Contracts;

    public class Pawn : IFigure
    {
        public Pawn(ChessColor color)
        {
            this.Color = color;
        }

        public ChessColor Color { get; init; }
    }
}
