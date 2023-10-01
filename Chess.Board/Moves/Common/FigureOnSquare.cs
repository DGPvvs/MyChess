namespace Chess.Board.Moves.Common
{
    using Chess.Board.Figures.Contracts;

    public class FigureOnSquare
    {
        public FigureOnSquare(IFigure figure, Square square)
        {
            this.Figure = figure;
            this.Square = square;
        }

        public IFigure Figure { get; private set; }

        public Square Square { get; private set; }
    }
}
