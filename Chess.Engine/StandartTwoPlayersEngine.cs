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
        private int currentPlayerIndex;

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

            this.SetFirstPlayerIndex();

            gameInitializationStrategy.Initialize(this.players, this.board);
            this.renderer.RenderBoard(this.board);
        }

        public void Start()
        {
            IPlayer player = this.GetNextPlayer();
            var move = this.inputProvider.GetNextPlayerMove();
        }


        public WinResult WinningConditions()
        {
            throw new NotImplementedException();
        }

        private void SetFirstPlayerIndex()
        {
            int i = 0;
            bool isLoopExit = false;

            while (!isLoopExit)
            {
                if (this.players[i].Color.Equals(ChessColor.While))
                {
                    this.currentPlayerIndex = i;
                    isLoopExit = true;
                }
            }
        }

        private IPlayer GetNextPlayer()
        {
            this.currentPlayerIndex++;

            if (this.currentPlayerIndex >= this.players.Count)
            {
                this.currentPlayerIndex = 0;
            }

            return this.players[this.currentPlayerIndex];
        }
    }
}
