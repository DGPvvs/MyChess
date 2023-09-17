namespace Chess
{
    using Chess.Engine.Contracts;
    using Chess.Engine.Initializations;
    using Chess.Engine;
    using Chess.InputProviders.Contracts;
    using Chess.InputProviders;
    using Chess.Renderers.Contracts;
    using Chess.Renderers;

    public static class ChessFasade
    {
        public static void Start() 
        {
            IRenderer renderer = new ConsoleRenderer();
            renderer.RenderMainMenu();

            IInputProvider inputProvider = new ConsoleInputProvider();

            IChessEngine chessEngine = new StandartTwoPlayersEngine(renderer, inputProvider);
            IGameInitializationStrategy strategy = new StandartStartGameInitializationStrategy();

            chessEngine.Initialize(strategy);

            chessEngine.Start();

            Console.ReadLine();

            Console.WriteLine("Hello, World!");
        }
    }
}
