namespace Chess.Engine
{
    using Chess.Common.Enums;
    using Chess.Engine.Contracts;
    using Chess.InputProviders.Contracts;
    using Chess.Players.Contracts;
    using Chess.Renderers.Contracts;
    using System.Collections.Generic;
    using Chess.Board;

    using static Chess.Common.Constants.GlobalConstants.BoardConstants;
    using Chess.Board.Contracts;

    public class StandartTwoPlayersEngine : IChessEngine
    {        
        private IList<IPlayer> players;
        private readonly IRenderer renderer;
        private readonly IInputProvider inputProvider;
        private readonly IBoard board;

        public StandartTwoPlayersEngine(IRenderer renderer, IInputProvider inputProvider)
        {
            this.renderer = renderer;
            this.inputProvider = inputProvider;
            this.board = new Board();
            this.players = new List<IPlayer>();
        }

        public IList<IPlayer> Players => new List<IPlayer>(this.players);

        public void Initialize(IGameInitializationStrategy gameInitializationStrategy)
        {
            this.players = this.inputProvider.GetPlayers(StandartPlayersNum);

            gameInitializationStrategy.Initialize(this.players, this.board);
            this.renderer.RenderBoard(this.board);
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
