namespace Chess.Engine.Contracts
{
    using Chess.Common.Enums;
    using Chess.Players.Contracts;

    public interface IChessEngine
    {
        public IEnumerable<IPlayer> MyProperty { get; }

        public void Initialize();

        public void Start();

        public WhinResult WinningConditions();
    }
}
