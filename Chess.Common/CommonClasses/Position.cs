namespace Chess.Common.CommonClasses
{
    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;
    using static Chess.Common.Constants.GlobalConstants.BoardConstants;

    public class Position
    {
        private readonly int row;
        private readonly char col;

        public Position(int row, char col) : base()
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row
        {
            get => this.row;
            init => this.row = value;
        }

        public char Col
        {
            get => this.col;
            init => this.col = value;
        }

        public static Position FromArrayCoordinates(int arrRow, int arrCol, int tottalRows) => new Position(tottalRows - arrRow, (char)('a' + arrCol));

        public static Position FromChessCoordinates(int chessRow, char chessCol)
        {
            Position newPosition = new Position(chessRow, chessCol);
            CheckIfValid(newPosition);
            return newPosition;
        }

        public static void CheckIfValid(Position position)
        {
            if (position.Row < MinimumRowValueOnBoard || position.Row > MaximumRowValueOnBoard)
            {
                throw new IndexOutOfRangeException(OutOfRangeRow);
            }            

            if (position.Col < MinimumColValueOnBoard || position.Col > MaximumColValueOnBoard)
            {
                throw new IndexOutOfRangeException(OutOfRangeCol);
            }
        }
    }
}
