namespace Chess.Board.Contracts
{
    using Chess.Common.CommonClasses;
    using Chess.Figures.Contracts;

    public interface IBoard
    {
        public int TotalRows { get; init; }

        public int TotalCols { get; init; }

        public void AddFigure(IFigure figure, Position position);

        public void AddFigure(IFigure figure, Point point);

        public void RemoveFigure(Position position);

        public IFigure GetFigureAtPosition(Position position);
    }
}
