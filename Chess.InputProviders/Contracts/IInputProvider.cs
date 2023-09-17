namespace Chess.InputProviders.Contracts
{
    using Chess.Players.Contracts;

    public interface IInputProvider
    {
        public IList<IPlayer> GetPlayers(int numberOfPlayers);
    }
}
