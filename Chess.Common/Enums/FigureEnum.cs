namespace Chess.Common.Enums
{
    public enum FigureEnum
    {
        None = '.',

        WhiteKing = 'K',
        WhiteQueen = 'Q',
        WhiteRook = 'R',
        WhiteBishop = 'B',
        WhiteKnight = 'N',
        WhitePawn = 'P',

        BlackKing = 'k',
        BlackQueen = 'q',
        BlackRook = 'r',
        BlackBishop = 'b',
        BlackKnight = 'n',
        BlackPawn = 'p'
    }

    public static class FigureMethod
    {
        public static char ToChar(this FigureEnum figure)
        {
            return (char)figure;
        }
    }
}
