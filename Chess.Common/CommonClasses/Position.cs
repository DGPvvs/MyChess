namespace Chess.Common.CommonClasses
{
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
    }
}
