namespace Chess.Renderers
{
    using Chess.Common.Enums;
    using Chess.Figures.Contracts;
    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;

    public static class ConsoleRendererHelper
    {
        public static ConsoleColor ToConsoleColor(this ChessColor chessColor)
        {
            switch (chessColor)
            {
                case ChessColor.Black:
                    return ConsoleColor.Black;
                case ChessColor.While:
                    return ConsoleColor.White;
                default:
                    throw new InvalidOperationException(InvaldColor);
            }
        }

        public static void PrintFigure(IFigure figure, ConsoleColor backgroundColor, ConsoleColor figureColor)
        {
            if (figure is null)
            {
                PrintEmptySquare(backgroundColor);
            }
        }

        private static void PrintEmptySquare(ConsoleColor backgroundColor)
        {
            throw new NotImplementedException();
        }
    }
}
