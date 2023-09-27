namespace Chess.Renderers
{
    using Chess.Board;
    using Chess.Board.Contracts;
    using Chess.Common.CommonClasses;
    using Chess.Common.ConsoleHelpers;
    using Chess.Figures.Contracts;
    using Chess.Renderers.Contracts;

    using System;

    using static Chess.Common.Constants.GlobalConstants.ConsoleRendererConstants;

    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "ШАХ";

        public void PrintErrorMessage(string message)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(message);

            Thread.Sleep(2000);

            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, 0);
        }

        public void RenderBoard(IBoard board)
        {
            Console.Clear();

            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            Point startPrint = new Point(
                (Console.WindowHeight - board.TotalRows * CharactersPerRowBoardSquare) / 2,
                (Console.WindowWidth - board.TotalCols * CharactersPerColBoardSquare) / 2);

            Point currentPrint = new Point(startPrint.Row, startPrint.Col);

            this.PrintBorder(startPrint, currentPrint, board);

            Console.BackgroundColor = ConsoleColor.Blue;
            int counter = 0;

            for (int top = 0; top < board.TotalRows; top++)
            {
                for (int left = 0; left < board.TotalCols; left++)
                {
                    currentPrint = new Point(
                        startPrint.Row + top * CharactersPerRowBoardSquare,
                        startPrint.Col + left * CharactersPerColBoardSquare);

                    ConsoleColor backgroundColor;

                    if ((counter % 2).Equals(0))
                    {
                        backgroundColor = LightSquareConsoleColor;
                    }
                    else
                    {
                        backgroundColor = DarkSquareConsoleColor;
                    }

                    Position position = Position.FromArrayCoordinates(top, left, board.TotalRows);

                    IFigure figure = board.GetFigureAtPosition(position);

                    ConsoleRendererHelper.PrintFigure(figure, backgroundColor, currentPrint.Row, currentPrint.Col);

                    counter++;
                }

                counter++;
            }

            Console.SetCursorPosition(Console.WindowWidth / 2, 2);
            Console.SetCursorPosition(0, 0);
        }

        private void PrintBorder(Point startPrint, Point currentPrint, IBoard board)
        {
            for (int i = startPrint.Row - 3; i < startPrint.Row + 4 + board.TotalRows * CharactersPerRowBoardSquare; i++)
            {
                Console.BackgroundColor = DarkSquareConsoleColor;
                Console.SetCursorPosition(currentPrint.Col - 4, i);
                Console.Write(" ");

                Console.SetCursorPosition(currentPrint.Col + 3 + board.TotalCols * CharactersPerColBoardSquare, i);
                Console.Write(" ");
            }

            for (int i = startPrint.Col - 3; i < startPrint.Col + 3 + board.TotalCols * CharactersPerColBoardSquare; i++)
            {
                Console.BackgroundColor = DarkSquareConsoleColor;
                Console.SetCursorPosition(i, currentPrint.Row - 3);
                Console.Write(" ");

                Console.SetCursorPosition(i, currentPrint.Row + 3 + board.TotalCols * CharactersPerColBoardSquare);
                Console.Write(" ");
            }

            int start = startPrint.Col + 4;
            Console.BackgroundColor = ConsoleColor.Black;

            for (int i = 0; i < board.TotalCols; i++)
            {
                Console.SetCursorPosition(start + i * CharactersPerColBoardSquare, startPrint.Row - 2);
                Console.Write($"{(char)('A' + i)}");

                Console.SetCursorPosition(start + i * CharactersPerColBoardSquare, startPrint.Row + board.TotalRows * CharactersPerRowBoardSquare + 2);
                Console.Write($"{(char)('A' + i)}");
            }

            for (int i = 0; i < board.TotalRows; i++)
            {
                Console.SetCursorPosition(startPrint.Col - 3, startPrint.Row + (board.TotalRows - i) * CharactersPerRowBoardSquare - 5);
                Console.WriteLine(i + 1);

                Console.SetCursorPosition(startPrint.Col + 2 + board.TotalCols * CharactersPerColBoardSquare, startPrint.Row + (board.TotalRows - i) * CharactersPerRowBoardSquare - 5);
                Console.WriteLine(i + 1);
            }
        }

        public void RenderMainMenu()
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;

            ConsoleHelpers.SetCursorAtCenter(Logo.Length);

            Console.WriteLine(Logo);

            Thread.Sleep(1000);
        }
    }
}
