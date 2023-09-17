namespace Chess
{
    using Chess.Engine;
    using Chess.Engine.Contracts;
    using Chess.Engine.Initializations;
    using Chess.InputProviders;
    using Chess.InputProviders.Contracts;
    using Chess.Renderers;
    using Chess.Renderers.Contracts;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            ChessFasade.Start();
        }
    }
}