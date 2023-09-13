namespace Chess.Board
{
    using Chess.Board.Contracts;
    using Chess.Common.CommonClasses;
    using Chess.Figures.Contracts;

    using static Chess.Common.Constants.GlobalConstants.BoardConstants;
    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;

    public class Board : IBoard
    {
        private readonly IFigure[,] board;
        private int totalRows;
        private int totalCols;

        public Board() : this(StandartRows, StandartCols)
        {

        }

        public Board(int rows, int cols)
        {
            this.TotalRows = rows;
            this.TotalCols = cols;
            this.board = new IFigure[this.TotalRows, this.TotalCols];
        }

        public int TotalRows
        {
            get => this.totalRows;
            init => this.totalRows = value;
        }

        public int TotalCols
        {
            get => this.totalCols;
            init => this.totalCols = value;
        }

        public void AddFigure(IFigure figure, Position position)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, NullFigureErrorMessage);
            this.PositionIsValid(position);

            Point  point = this.CalculatePosition(position);

            this.AddFigure(figure, point);
        }

        public void AddFigure(IFigure figure, Point point)
        {
            this.board[point.Row, point.Col] = figure;
        }

        public void RemoveFigure(Position position)
        {
            this.PositionIsValid(position);

            Point point = this.CalculatePosition(position);

            this.board[point.Row, point.Col] = null;
        }

        private Point CalculatePosition(Position position)
        {
            this.PositionIsValid(position);
            int returnRow = this.TotalRows - position.Row;

            char col = char.Parse(position.Col.ToString().ToLower());
            int returnCol = col - 'a';

            return new Point(returnRow, returnCol);
        }

        private void PositionIsValid(Position position)
        {
            if (position.Row < 1 || position.Row > this.TotalRows )
            {
                throw new IndexOutOfRangeException(OutOfRangeRow);
            }

            char col = char.Parse(position.Col.ToString().ToLower());

            if (col < 'a' || col > this.TotalCols - 'a')
            {
                throw new IndexOutOfRangeException(OutOfRangeCol);
            }
        }
    }
}
