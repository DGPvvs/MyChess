namespace Chess.Renderers
{
    using Chess.Common.Enums;
    using Chess.Figures;
    using Chess.Figures.Contracts;

    using static Chess.Common.Constants.GlobalConstants.ConsoleRendererConstants;
    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;
    using static Chess.Renderers.Common.ConsoleFigurePatterns;

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

        public static void PrintFigure(IFigure figure, ConsoleColor backgroundColor, int top, int left)
        {
            if (figure is null)
            {
                PrintEmptySquare(backgroundColor, top, left);
            }

            var pawn = pawnPattern;
            var rook = rookPattern;
            var knight = knightPattern;
            var bishop = bishopPattern;

            if (figure is Pawn) 
            {
                for (int i = 0; i < pawnPattern.GetLength(0); i++)
                {
                    for (int j = 0; j < pawnPattern.GetLength(1); j++)
                    {
                        if (pawnPattern[i, j].Equals(ElementEnum.T))
                        {
                            Console.BackgroundColor = figure.Color.ToConsoleColor();
                        }
                        else
                        {
                            Console.BackgroundColor = backgroundColor;
                        }

                        Console.SetCursorPosition(left + j, top + i);
                        Console.Write(" ");
                    }

                }
            }

            if (figure is Rook)
            {
                for (int i = 0; i < rookPattern.GetLength(0); i++)
                {
                    for (int j = 0; j < rookPattern.GetLength(1); j++)
                    {
                        if (rookPattern[i, j].Equals(ElementEnum.T))
                        {
                            Console.BackgroundColor = figure.Color.ToConsoleColor();
                        }
                        else
                        {
                            Console.BackgroundColor = backgroundColor;
                        }

                        Console.SetCursorPosition(left + j, top + i);
                        Console.Write(" ");
                    }

                }
            }

            if (figure is Knight)
            {
                for (int i = 0; i < knightPattern.GetLength(0); i++)
                {
                    for (int j = 0; j < knightPattern.GetLength(1); j++)
                    {
                        if (knightPattern[i, j].Equals(ElementEnum.T))
                        {
                            Console.BackgroundColor = figure.Color.ToConsoleColor();
                        }
                        else
                        {
                            Console.BackgroundColor = backgroundColor;
                        }

                        Console.SetCursorPosition(left + j, top + i);
                        Console.Write(" ");
                    }

                }
            }

            if (figure is Bishop)
            {
                for (int i = 0; i < bishopPattern.GetLength(0); i++)
                {
                    for (int j = 0; j < bishopPattern.GetLength(1); j++)
                    {
                        if (bishopPattern[i, j].Equals(ElementEnum.T))
                        {
                            Console.BackgroundColor = figure.Color.ToConsoleColor();
                        }
                        else
                        {
                            Console.BackgroundColor = backgroundColor;
                        }

                        Console.SetCursorPosition(left + j, top + i);
                        Console.Write(" ");
                    }

                }
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
