namespace Chess.Common.CommonClasses
{
    using System;

    public class Point : IComparable<Point>
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Point(int newRow, int newCol)
        {
            this.Row = newRow;
            this.Col = newCol;
        }

        public int CompareTo(Point other)
        {
            int comp = this.Row.CompareTo(other.Row);

            if (comp == 0)
            {
                comp = this.Col.CompareTo(other.Col);
            }

            return comp;
        }
    }
}
