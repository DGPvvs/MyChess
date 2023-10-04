namespace Chess.Board.Moves
{
    using Chess.Board.Contracts;
    using Chess.Board.Figures.Contracts;
    using Chess.Board.Moves.Common;
    using Chess.Board.Moves.Contracts;
    using Chess.Common.CommonClasses;

    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;

    public class NormalBishopMovement : IMoves
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
            Position from = move.From;
            Position to = move.To;

            int rowDistans = Math.Abs(from.Row - to.Row);
            int colDistans = Math.Abs(from.Col - to.Col);

            if (!rowDistans.Equals(colDistans))
            {
                throw new InvalidOperationException(BishopInvalidMove);
            }

            Position at = from;
            int deltaRow = to.Row - from.Row;
            int deltaCol = to.Col - from.Col;
            var singRow = Math.Sign(deltaRow);
            var singCol = Math.Sign(deltaCol);

            bool flag = true;

            do
            {
                at = new Position(at.Row + singRow, (char)((int)at.Col + singCol));                
                if (at.CompareTo(to) == 0)
                {
                    return;
                }

                flag = board.ValidPosition(at);

            } while (flag && board.GetFigureAtPosition(at) == null);

            throw new InvalidOperationException(BishopInvalidMove);
        }
    }
}
