namespace Chess.Renderers
{
    using Chess.Board.Contracts;
    using Chess.Common.CommonClasses;
    using Chess.Common.ConsoleHelpers;
    using Chess.Figures.Contracts;
    using Chess.Renderers.Contracts;
    using System;

    public class ConsoleRenderer : IRenderer
    {
        private const int CharactersPerRowBoardSquare = 9;
        private const int CharactersPerColBoardSquare = 9;

        private const ConsoleColor DarkSquareConsoleColor = ConsoleColor.Cyan;
        private const ConsoleColor LightSquareConsoleColor = ConsoleColor.Gray;

        private const string Logo = "ШАХ";        

        

        public void RenderBoard(IBoard board)
        {
            Console.Clear();

            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            Point startPrint = new Point(
                (Console.WindowHeight - board.TotalRows * CharactersPerRowBoardSquare) / 2,
                (Console.WindowWidth - board.TotalCols * CharactersPerColBoardSquare) / 2);

            Point currentPrint = new Point(startPrint.Row, startPrint.Col);

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
                        backgroundColor = DarkSquareConsoleColor;
                        Console.BackgroundColor = DarkSquareConsoleColor;
                    }
                    else
                    {
                        backgroundColor = LightSquareConsoleColor;
                        Console.BackgroundColor = LightSquareConsoleColor;
                    }

                    Position position = Position.FromArrayCoordinates(top, left, board.TotalRows);

                    IFigure figure = board.GetFigureAtPosition(position);

                    ConsoleRendererHelper.PrintFigure(figure, Console.BackgroundColor, figure.Color.ToConsoleColor());

                    for (int i = 0; i < CharactersPerRowBoardSquare; i++)
                    {
                        for (int j = 0; j < CharactersPerColBoardSquare; j++)
                        {
                            Console.SetCursorPosition(currentPrint.Col + j, currentPrint.Row + i);
                            Console.Write(" ");
                        }
                    }

                    counter++;
                }

                counter++;
            }



            Console.ReadLine();

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
