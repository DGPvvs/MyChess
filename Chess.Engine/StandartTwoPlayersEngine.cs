namespace Chess.Engine
{
    using Chess.Common.Enums;
    using Chess.Engine.Contracts;
    using Chess.Players.Contracts;
    using System.Collections.Generic;

    public class StandartTwoPlayersEngine : IChessEngine
    {
        public IEnumerable<IPlayer> MyProperty => throw new NotImplementedException();

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public WhinResult WinningConditions()
        {
            throw new NotImplementedException();
        }
    }
}
