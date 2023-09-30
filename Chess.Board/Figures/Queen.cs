namespace Chess.Board.Figures
{
    using Chess.Board.Figures.Contracts;
    using Chess.Board.Moves.Contracts;
    using Chess.Common.Enums;
    using System.Collections.Generic;

    public class Queen : BaseFigure
    {
        public Queen(ChessColor color) : base(color)
        {
        }

        public override ICollection<IMoves> Move()
        {
            throw new NotImplementedException();
        }
    }
}
