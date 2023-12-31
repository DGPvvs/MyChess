﻿namespace Chess.Figures
{
    using Chess.Common.Enums;
    using Chess.Figures.Contracts;
    using Class.Moves.Contracts;
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
