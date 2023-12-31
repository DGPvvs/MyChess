﻿namespace Chess.Figures.Contracts
{
    using Chess.Common.Enums;
    using Class.Moves.Contracts;

    public interface IFigure
    {
        public ChessColor Color { get; init; }

        public ICollection<IMoves> Move();
    }
}
