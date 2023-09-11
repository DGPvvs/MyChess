namespace Chess.Engine.Initializations
{
    using Chess.Board.Contracts;
    using Chess.Players.Contracts;

    public interface IGameInitializationStrategy
    {
        public void Initialize(IEnumerable<IPlayer> players, IBoard board);
    }
}
