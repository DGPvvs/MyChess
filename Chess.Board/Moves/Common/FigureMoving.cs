namespace Chess.Board.Moves.Common
{
    using Chess.Board.Figures.Contracts;
    using Chess.Common.CommonClasses;

    public class FigureMoving : IComparable<FigureMoving>
    {
        public FigureMoving(IFigure figure, Move move)
        {
            this.Figure = figure;
            this.From = new Square(move.From.Row, move.From.Col);
        }

        public FigureMoving(FigureOnSquare figureOnSquare, Square to, IFigure? promotion = null)
        {
            this.Figure = figureOnSquare.Figure;
            this.From = figureOnSquare.Square;
            this.To = to;
            this.Promotion = promotion;
        }

        public IFigure Figure { get; private set; }

        public Square From { get; private set; }

        public Square To { get; private set; }

        public IFigure Promotion { get; private set; }

        public int DeltaX => To.X - From.X;

        public int DeltaY => To.Y - From.Y;

        public int AbsDeltaX => Math.Abs(DeltaX);

        public int AbsDeltaY => Math.Abs(DeltaY);

        public int SingX => Math.Sign(DeltaX);

        public int SingY => Math.Sign(DeltaY);

        public int CompareTo(FigureMoving other)
        {
            int comp = this.From.X.CompareTo(other.To.X);

            if (comp == 0)
            {
                comp = this.From.Y.CompareTo(other.To.Y);
            }

            return comp;
        }

        public override bool Equals(object? obj)
        {
            FigureMoving? fm = obj as FigureMoving;

            if (fm is null)
            {
                return false;
            }

            return fm.CompareTo(this).Equals(0);
        }

        public override int GetHashCode()
        {
            return ((this.From.X.GetHashCode() ^ 2) * this.From.Y.GetHashCode())
                 + ((this.To.X.GetHashCode() ^ 2) * this.To.Y.GetHashCode());
        }

        public override string ToString()
        {
            string promotion = string.Empty;

            if (Promotion != null )
            {
                promotion = Promotion.ToString();
            }

            return $"{Figure.ToString()} {From.Name} {To.Name} {promotion}";
        }
    }

}
