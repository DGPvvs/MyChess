namespace Chess.Board.Figures
{
    using Chess.Board.Contracts;
    using Chess.Board.Figures.Contracts;
    using Chess.Board.Moves.Common;
    using Chess.Board.Moves.Contracts;
    using Chess.Common.CommonClasses;

    public class AnPassanMovement : IMoves
    {
        public bool CanFigureMove(FigureMoving fm, IBoard board)
        {
            throw new NotImplementedException();
        }

        public bool CanMove(FigureMoving fm, IBoard board)
        {
            throw new NotImplementedException();
        }

        public bool CanMoveFrom(FigureMoving fm, IBoard board)
        {
            throw new NotImplementedException();
        }

        public bool CanMoveTo(FigureMoving fm, IBoard board)
        {
            throw new NotImplementedException();
        }

        public void ValidateMove(IFigure figure, IBoard board, Move move)
        {
            throw new NotImplementedException();
        }
    }
}