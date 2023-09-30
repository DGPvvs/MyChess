namespace Chess.Players.Contracts
{
    using Chess.Board.Figures.Contracts;
    using Chess.Common.Enums;

    public interface IPlayer
    {
        public string Name { get; }

        public ChessColor Color { get; }

        public IList<IFigure> Figures { get; }

        public void AddFigure(IFigure figure);

        public void RemoveFigure(IFigure figure);
    }
}
