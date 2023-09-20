namespace Chess.Renderers.Contracts
{
    using Chess.Board.Contracts;
    using Chess.Figures.Contracts;

    public interface IRenderer
    {
        public void RenderBoard(IBoard board);

        public void RenderMainMenu();
    }
}
