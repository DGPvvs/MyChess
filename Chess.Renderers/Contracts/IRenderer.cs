namespace Chess.Renderers.Contracts
{
    using Chess.Board.Contracts;

    public interface IRenderer
    {
        public void RenderBoard(IBoard board);

        public void RenderMainMenu();
    }
}
