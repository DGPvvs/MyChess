namespace Chess.Renderers
{
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
