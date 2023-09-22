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
            else
            {



                Dictionary<string, char[,]> figurePatterns = new Dictionary<string, char[,]>()
            {
                {typeof(Pawn).Name, pawnPattern },
                {typeof(Rook).Name, rookPattern },
                {typeof(Knight).Name, knightPattern },
                {typeof(Bishop).Name, bishopPattern },
                {typeof(Queen).Name, queenPattern },
                {typeof(King).Name, kingPattern }
            };

                switch (figure.GetType().Name)
                {
                    case nameof(Pawn):
                        PrintFigureSquare(figurePatterns[nameof(Pawn)], figure, backgroundColor, top, left);
                        break;
                    case nameof(Rook):
                        PrintFigureSquare(figurePatterns[nameof(Rook)], figure, backgroundColor, top, left);
                        break;
                    case nameof(Knight):
                        PrintFigureSquare(figurePatterns[nameof(Knight)], figure, backgroundColor, top, left);
                        break;
                    case nameof(Bishop):
                        PrintFigureSquare(figurePatterns[nameof(Bishop)], figure, backgroundColor, top, left);
                        break;
                    case nameof(Queen):
                        PrintFigureSquare(figurePatterns[nameof(Queen)], figure, backgroundColor, top, left);
                        break;
                    case nameof(King):
                        PrintFigureSquare(figurePatterns[nameof(King)], figure, backgroundColor, top, left);
                        break;

                    default:
                        break;
                }
            }
        }

        private static void PrintFigureSquare(char[,] elementEnums, IFigure figure, ConsoleColor backgroundColor, int top, int left)
        {
            for (int i = 0; i < elementEnums.GetLength(0); i++)
            {
                for (int j = 0; j < elementEnums.GetLength(1); j++)
                {
                    if (elementEnums[i, j].Equals((char)ElementEnum.T))
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
