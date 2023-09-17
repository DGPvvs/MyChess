namespace Chess.Engine.Contracts
{
    using Chess.Common.Enums;
    using Chess.Players.Contracts;

    public interface IChessEngine
    {
        public IList<IPlayer> Players { get; }

        public void Initialize(IGameInitializationStrategy gameInitializationStrategy);

        public void Start();

        public WinResult WinningConditions();
    }
}
