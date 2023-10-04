namespace Chess.Board.Moves.Strategy
{
    using Chess.Board.Moves.Contracts;
    using Chess.Common.Enums;
    using System.Collections.Generic;

    public class NormalMovmentStrategy : IMovementStrategy
    {
        private Dictionary<FigureEnum, IList<IMoves>> moves = new Dictionary<FigureEnum, IList<IMoves>>()
        {
            { FigureEnum.BlackPawn, new List<IMoves>(){ new NormalPownMove(), new AnPassanMovement() } },
            { FigureEnum.WhitePawn, new List<IMoves>(){ new NormalPownMove(), new AnPassanMovement() } },
            { FigureEnum.BlackBishop, new List<IMoves>(){ new NormalBishopMovement() } },
            { FigureEnum.WhiteBishop, new List<IMoves>(){ new NormalBishopMovement() } },
        };

        public IList<IMoves> GetMoves(FigureEnum figure) => this.moves[figure];
    }
}
