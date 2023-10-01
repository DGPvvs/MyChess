namespace Chess.Board.Moves.Contracts
{
    using Chess.Board.Contracts;
    using Chess.Board.Figures.Contracts;
    using Chess.Board.Moves.Common;
    using Chess.Common.CommonClasses;

    public interface IMoves
    {
        public void ValidateMove(IFigure figure, IBoard board, Move move);

        public bool CanMove(FigureMoving fm, IBoard board);

        public bool CanFigureMove(FigureMoving fm, IBoard board);

        public bool CanMoveTo(FigureMoving fm, IBoard board);

        public bool CanMoveFrom(FigureMoving fm, IBoard board);
    }
}
