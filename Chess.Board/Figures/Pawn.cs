namespace Chess.Board.Figures
{
    using Chess.Board.Figures.Contracts;
    using Chess.Board.Moves;
    using Chess.Board.Moves.Contracts;
    using Chess.Common.Enums;
    using System.Collections.Generic;

    public class Pawn : BaseFigure
    {
        public Pawn(ChessColor color) : base(color)
        {
        }

        public override ICollection<IMoves> Move(IMovementStrategy movementStrategy, FigureEnum figure)
        {
            return movementStrategy.GetMoves(figure);
            return new List<IMoves>()
            {
                new NormalPownMove(),
                new AnPassanMovement()
            };
//            var result = this.CanPownMove();
            throw new NotImplementedException();
        }
    }
}
