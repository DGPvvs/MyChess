namespace Chess
{
    using Chess.Renderers;
    using Chess.Renderers.Contracts;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer();
            renderer.RenderMainMenu();
            Console.WriteLine("Hello, World!");
        }
    }
}