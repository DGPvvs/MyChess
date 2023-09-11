namespace Chess.Engine
{
    using Chess.Common.Enums;
    using Chess.Engine.Contracts;
    using Chess.Players.Contracts;
    using System.Collections.Generic;

    public class StandartTwoPlayersEngine : IChessEngine
    {
        private readonly IEnumerable<IPlayer> players;

        public IEnumerable<IPlayer> Players => new List<IPlayer>(this.players);

        public void Initialize(IGameInitializationStrategy gameInitializationStrategy)
        {
            //gameInitializationStrategy.Initialize(this.Players, this.Board);
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public WinResult WinningConditions()
        {
            throw new NotImplementedException();
        }
    }
}
