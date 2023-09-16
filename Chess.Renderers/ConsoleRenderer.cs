namespace Chess.Renderers
{
    using Chess.Board.Contracts;
    using Chess.Common.ConsoleHelpers;
    using Chess.Renderers.Contracts;

    public class ConsoleRenderer : IRenderer
    {
        private const int WindowWidth = 100;
        private const int WindowHeight = 30;

        private const string Logo = "ШАХ";
        public void RenderBoard(IBoard board)
        {
            throw new NotImplementedException();
        }

        public void RenderMainMenu()
        {
            Console.SetWindowSize(WindowWidth, WindowHeight);

            Console.WindowTop = 0;
            Console.WindowLeft = 0;

            Console.BufferWidth = Console.WindowWidth;
            Console.WindowHeight = Console.WindowHeight;

            ConsoleHelpers.SetCursorAtCenter(Logo.Length);

            Console.WriteLine(Logo);

            Thread.Sleep(1000);
        }
    }
}
