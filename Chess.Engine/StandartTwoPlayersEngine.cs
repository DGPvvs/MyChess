namespace Chess.Engine
{
    using Chess.Common.Enums;
    using Chess.Engine.Contracts;
    using Chess.InputProviders.Contracts;
    using Chess.Players.Contracts;
    using Chess.Renderers.Contracts;
    using System.Collections.Generic;

    public class StandartTwoPlayersEngine : IChessEngine
    {
        private readonly IEnumerable<IPlayer> players;
        private readonly IRenderer renderer;
        private readonly IInputProvider inputProvider1;

        public StandartTwoPlayersEngine(IRenderer renderer, IInputProvider inputProvider)
        {
            this.renderer = renderer;
            this.inputProvider1 = inputProvider;
        }

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
