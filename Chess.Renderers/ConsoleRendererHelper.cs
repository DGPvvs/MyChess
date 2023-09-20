namespace Chess.Renderers
{
    using Chess.Common.Enums;
    using Chess.Common.CommonClasses;
    using Chess.Figures.Contracts;
   
    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;

    public static class ConsoleRendererHelper
    {
        private const int CharactersPerRowBoardSquare = 9;
        private const int CharactersPerColBoardSquare = 9;

        private const ConsoleColor DarkSquareConsoleColor = ConsoleColor.Cyan;
        private const ConsoleColor LightSquareConsoleColor = ConsoleColor.Gray;

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

        public static void PrintFigure(IFigure figure, ConsoleColor backgroundColor, int top, int left)
        {
            if (figure is null)
            {
                PrintEmptySquare(backgroundColor, top, left);
            }
        }

        private static void PrintEmptySquare(ConsoleColor backgroundColor, int top, int left)
        {
            for (int i = 0; i < CharactersPerRowBoardSquare; i++)
            {
                for (int j = 0; j < CharactersPerColBoardSquare; j++)
                {
                    Console.BackgroundColor = backgroundColor;
                    Console.SetCursorPosition(left + j, top + i);
                    Console.Write(" ");
                }
            }
        }
    }
}
