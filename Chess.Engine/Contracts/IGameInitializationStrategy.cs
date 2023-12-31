﻿namespace Chess.Engine.Contracts
{
    using Chess.Board.Contracts;
    using Chess.Players.Contracts;

    public interface IGameInitializationStrategy
    {
        public void Initialize(IList<IPlayer> players, IBoard board);
    }
}
