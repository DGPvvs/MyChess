namespace Chess.Engine.Initializations
{
    using Chess.Board.Contracts;
    using Chess.Engine.Contracts;
    using Chess.Players.Contracts;
    using System.Collections.Generic;

    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;
    using static Chess.Common.Constants.GlobalConstants.BoardConstants;

    public class StandartStartGameInitializationStrategy : IGameInitializationStrategy
    {
        public void Initialize(ICollection<IPlayer> players, IBoard board)
        {
            if (!players.Count.Equals(2))
            {
                throw new InvalidOperationException(StandartSrategyMustTwoPlayers);
            }

            if (!board.TotalRows.Equals(StandartRows) && !board.TotalCols.Equals(StandartCols))
            {
                throw new InvalidOperationException(StandartSrategyMustEightRowsAndCols);
            }


        }
    }
}
