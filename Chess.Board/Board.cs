namespace Chess.Board
{
    using Chess.Figures.Contracts;

    using static Chess.Common.Constants.GlobalConstants.BoardConstants;


    public class Board
    {
        private readonly IFigure[,] board;
        private int totalRows;
        private int totalCols;

        public Board() : this(StandartRows, StandartCols)
        {

        }

        public Board(int rows, int cols)
        {
            this.totalRows = rows;
            this.totalCols = cols;
            this.board = new IFigure[totalRows, totalCols];
        }

        public int TotalRows
        {
            get => this.totalRows;
            init => this.totalRows = value;
        }

        public int TotalCols
        {
            get => this.TotalCols;
            init => this.totalCols = value;
        }
    }

}
