namespace Chess.Engine
{
    using Chess.Board;
    using Chess.Board.Contracts;
    using Chess.Board.Figures.Contracts;
    using Chess.Board.Moves.Contracts;
    using Chess.Board.Moves.Strategy;
    using Chess.Common.CommonClasses;
    using Chess.Common.Enums;
    using Chess.Engine.Contracts;
    using Chess.InputProviders.Contracts;
    using Chess.Players.Contracts;
    using Chess.Renderers.Contracts;
    using System.Collections.Generic;
    using static Chess.Common.Constants.GlobalConstants.BoardConstants;
    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;

    public class StandartTwoPlayersEngine : IChessEngine
    {
        private IList<IPlayer> players;
        private int currentPlayerIndex;

        private readonly IRenderer renderer;
        private readonly IInputProvider inputProvider;
        private readonly IBoard board;
        private readonly IMovementStrategy movementStrategy;

        public StandartTwoPlayersEngine(IRenderer renderer, IInputProvider inputProvider)
        {
            this.renderer = renderer;
            this.inputProvider = inputProvider;
            this.movementStrategy = new NormalMovmentStrategy();
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
            while (true)
            {
                try
                {
                    IPlayer player = this.GetNextPlayer();
                    Move move = this.inputProvider.GetNextPlayerMove(player);
                    Position from = move.From;
                    Position to = move.To;

                    IFigure figure = this.board.GetFigureAtPosition(from);
                    this.CheckIfPlayerOwnsFigure(player, figure, from);
                    this.CheckIfToPositionIsEmpty(figure, to);


                    var aviableMoves = figure.Move(this.movementStrategy, this.ConvertFigure(figure));

                    foreach (var mov in aviableMoves)
                    {
                        mov.ValidateMove(figure, board, move);

                    }

                    board.MoveFigureAtPosition(figure, from, to);
                    this.renderer.RenderBoard(board);
                }
                catch (Exception ex)
                {
                    this.currentPlayerIndex--;
                    this.renderer.PrintErrorMessage(ex.Message);
                }
            }
        }

        private FigureEnum ConvertFigure(IFigure figure)
        {
            var figureColor = figure.Color.ToString();
            if (figureColor.Contains("While"))
            {
                figureColor = "White";
            }

            var figureName = figure.GetType().Name;

            return (FigureEnum)Enum.Parse(typeof(FigureEnum), figureColor + figureName);
        }

        private void CheckIfToPositionIsEmpty(IFigure figure, Position to)
        {
            IFigure figureAtPosition = this.board.GetFigureAtPosition(to);

            if (!(figureAtPosition is null) && figureAtPosition.Color.Equals(figure.Color))
            {
                throw new InvalidOperationException(string.Format(AlresdyHaveYourFigureAtPosition, to.Col, to.Row));
            }
        }

        private void CheckIfPlayerOwnsFigure(IPlayer player, IFigure figure, Position from)
        {
            if (figure is null)
            {
                throw new InvalidOperationException(string.Format(FromPositionIsEmpty, from.Col, from.Row));
            }

            if (!figure.Color.Equals(player.Color))
            {
                throw new InvalidOperationException(string.Format(ThisFigureIsNotYours, from.Col, from.Row));
            }
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
            IPlayer result = this.players[this.currentPlayerIndex];

            this.currentPlayerIndex++;

            if (this.currentPlayerIndex >= this.players.Count)
            {
                this.currentPlayerIndex = 0;
            }

            return result;
        }
    }
}
