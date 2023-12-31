﻿namespace Chess.Figures.Contracts
{
    using Chess.Common.Enums;
    using Class.Moves.Contracts;

    public abstract class BaseFigure : IFigure
    {
        protected BaseFigure(ChessColor color)
        {
            Color = color;
        }

        public ChessColor Color { get; init; }

        public abstract ICollection<IMoves> Move();
    }
}
