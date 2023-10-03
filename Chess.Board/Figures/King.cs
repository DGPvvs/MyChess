namespace Chess.Board.Figures
{
    using Chess.Board.Figures.Contracts;
    using Chess.Board.Moves.Contracts;
    using Chess.Common.Enums;
    using System.Collections.Generic;

    public class King : BaseFigure
    {
        public King(ChessColor color) : base(color)
        {
        }

        public override ICollection<IMoves> Move(IMovementStrategy movementStrategy, FigureEnum figure)
        {
            throw new NotImplementedException();
        }
    }
}
