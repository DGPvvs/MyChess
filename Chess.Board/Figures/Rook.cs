﻿namespace Chess.Board.Figures
{
    using Chess.Board.Figures.Contracts;
    using Chess.Board.Moves.Contracts;
    using Chess.Common.Enums;
    using System.Collections.Generic;

    public class Rook : BaseFigure
    {
        public Rook(ChessColor color) : base(color)
        {
        }

        public override ICollection<IMoves> Move()
        {
            throw new NotImplementedException();
        }
    }
}
