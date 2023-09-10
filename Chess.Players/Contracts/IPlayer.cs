namespace Chess.Players.Contracts
{
    using Chess.Common.Enums;
    using Chess.Figures.Contracts;

    public interface IPlayer
    {
        public ChessColor Color { get; }

        public IList<IFigure> Figures { get; }

        public void AddFigure(IFigure figure);

        public void RemoveFigure(IFigure figure);
    }
}
