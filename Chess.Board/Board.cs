namespace Chess.Board
{
    using Chess.Figures.Contracts;

    public class Board
    {
        private IFigure[,] board;
        private int totalRows;
        private int totalCols;

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
