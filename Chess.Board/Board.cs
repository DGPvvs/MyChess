namespace Chess.Board
{
    using Chess.Board.Contracts;
    using Chess.Board.Figures.Contracts;
    using Chess.Common.CommonClasses;

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
            Position.CheckIfValid(position);

            Point  point = this.CalculatePosition(position);

            this.AddFigure(figure, point);
        }

        public void AddFigure(IFigure figure, Point point)
        {
            this.board[point.Row, point.Col] = figure;
        }

        public IFigure GetFigureAtPosition(Position position)
        {
            Point point = this.CalculatePosition(position);

            return this.board[point.Row, point.Col];
        }

        public void MoveFigureAtPosition(IFigure figure, Position from, Position to)
        {
            this.RemoveFigure(from);
            this.AddFigure(figure, to);
        }

        public void RemoveFigure(Position position)
        {
            Position.CheckIfValid(position);

            Point point = this.CalculatePosition(position);

            this.board[point.Row, point.Col] = null;
        }

        private Point CalculatePosition(Position position)
        {
            Position.CheckIfValid(position);
            int returnRow = position.Row - 1;

            char col = char.Parse(position.Col.ToString().ToLower());
            int returnCol = col - 'a';

            return new Point(returnRow, returnCol);
        }
    }
}
