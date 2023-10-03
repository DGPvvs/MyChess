namespace Chess.Board.Contracts
{
    using Chess.Board.Figures.Contracts;
    using Chess.Common.CommonClasses;

    public interface IBoard
    {
        public int TotalRows { get; init; }

        public int TotalCols { get; init; }

        public void AddFigure(IFigure figure, Position position);

        public void AddFigure(IFigure figure, Point point);

        public void RemoveFigure(Position position);

        public IFigure GetFigureAtPosition(Position position);

        public void MoveFigureAtPosition(IFigure figure, Position from, Position to);
    }
}
