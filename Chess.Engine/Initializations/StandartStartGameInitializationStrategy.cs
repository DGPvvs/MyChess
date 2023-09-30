namespace Chess.Engine.Initializations
{
    using Chess.Board.Contracts;
    using Chess.Board.Figures;
    using Chess.Board.Figures.Contracts;
    using Chess.Common.CommonClasses;
    using Chess.Common.Enums;
    using Chess.Engine.Contracts;
    using Chess.Players.Contracts;
    using System.Collections.Generic;
    using static Chess.Common.Constants.GlobalConstants.BoardConstants;
    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;
    using static Chess.Common.Constants.GlobalConstants.Fen;

    public class StandartStartGameInitializationStrategy : IGameInitializationStrategy
    {
        public void Initialize(IList<IPlayer> players, IBoard board)
        {
            this.ValidateStrategy(players, board);
            this.Init(players, board);
            


        }

        private void Init(IList<IPlayer> players,IBoard board)
        {
            string[] fenParts = StandartFen.Split(' ', StringSplitOptions.RemoveEmptyEntries);            

            this.InitFigures(fenParts[0], players, board);
        }

        private void InitFigures(string data, IList<IPlayer> players, IBoard board)
        {
            for (int j = 8; j >= 2; j--)
            {
                data = data.Replace(j.ToString(), $"{j - 1}1");
            }

            data = data.Replace('1', '.');

            string[] lines = data.Split('/', StringSplitOptions.RemoveEmptyEntries);

            var firstPlayer = players[0];
            var secondPlayer = players[1];

            for (int y = 7; y >= 0; y--)
            {
                for (int x = 0; x < 8; x++)
                {
                    FigureEnum fig = FigureEnum.None;

                    if (!lines[7 - y][x].Equals("."))
                    {
                        fig = (FigureEnum)lines[7 - y][x];

                        Point point = new Point(y, x);

                        IFigure? figure = null;

                        switch (fig)
                        {
                            case FigureEnum.WhiteKing:
                                figure = new King(ChessColor.While);
                                firstPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.WhiteQueen:
                                figure = new Queen(ChessColor.While);
                                firstPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.WhiteRook:
                                figure = new Rook(ChessColor.While);
                                firstPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.WhiteBishop:
                                figure = new Bishop(ChessColor.While);
                                firstPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.WhiteKnight:
                                figure = new Knight(ChessColor.While);
                                firstPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.WhitePawn:
                                figure = new Pawn(ChessColor.While);
                                firstPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.BlackKing:
                                figure = new King(ChessColor.Black);
                                secondPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.BlackQueen:
                                figure = new Queen(ChessColor.Black);
                                secondPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.BlackRook:
                                figure = new Rook(ChessColor.Black);
                                secondPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.BlackBishop:
                                figure = new Bishop(ChessColor.Black);
                                secondPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.BlackKnight:
                                figure = new Knight(ChessColor.Black);
                                secondPlayer.AddFigure(figure);
                                break;
                            case FigureEnum.BlackPawn:
                                figure = new Pawn(ChessColor.Black);
                                secondPlayer.AddFigure(figure);
                                break;
                            default:
                                break;
                        }

                        board.AddFigure(figure, point);
                    }                    
                }
            }
        }

        private void ValidateStrategy(ICollection<IPlayer> players, IBoard board)
        {
            if (!players.Count.Equals(StandartPlayersNum))
            {
                throw new InvalidOperationException(StandartSrategyMustTwoPlayers);
            }

            if (!board.TotalRows.Equals(StandartRows) || !board.TotalCols.Equals(StandartCols))
            {
                throw new InvalidOperationException(StandartSrategyMustEightRowsAndCols);
            }
        }
    }
}
