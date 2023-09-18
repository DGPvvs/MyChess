namespace Chess.Renderers
{
    using Chess.Board.Contracts;
    using Chess.Common.CommonClasses;
    using Chess.Common.ConsoleHelpers;
    using Chess.Renderers.Contracts;

    public class ConsoleRenderer : IRenderer
    {
        private const int CharactersPerRowBoardSquare = 9;
        private const int CharactersPerColBoardSquare = 9;

        private const ConsoleColor DarkSquareConsoleColor = ConsoleColor.DarkCyan;
        private const ConsoleColor LightSquareConsoleColor = ConsoleColor.Gray;

        private const string Logo = "ШАХ";

        public void RenderBoard(IBoard board)
        {
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

                    if ((counter % 2).Equals(0))
                    {
                        Console.BackgroundColor = DarkSquareConsoleColor;
                    }
                    else
                    {
                        Console.BackgroundColor = LightSquareConsoleColor;
                    }

                    counter++;

                    Console.SetCursorPosition(currentPrint.Col, currentPrint.Row);
                    Console.Write(" ");
                }
            }



            Console.ReadLine();

        }

        public void RenderMainMenu()
        {
            ConsoleHelpers.SetCursorAtCenter(Logo.Length);

            Console.WriteLine(Logo);

            Thread.Sleep(1000);
        }
    }
}
