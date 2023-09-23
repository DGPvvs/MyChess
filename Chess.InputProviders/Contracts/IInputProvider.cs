namespace Chess.InputProviders.Contracts
{
    using Chess.Common.CommonClasses;
    using Chess.Players.Contracts;

    public interface IInputProvider
    {
        public IList<IPlayer> GetPlayers(int numberOfPlayers);

        public Move GetNextPlayerMove(IPlayer player);
    }
}
