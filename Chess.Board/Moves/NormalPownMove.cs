﻿namespace Chess.Board.Moves
{
    using Chess.Board.Contracts;
    using Chess.Board.Figures.Contracts;
    using Chess.Board.Moves.Common;
    using Chess.Board.Moves.Contracts;
    using Chess.Common.CommonClasses;
    using Chess.Common.Enums;

    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;

    public class NormalPownMove : IMoves
    {
        public bool CanFigureMove(FigureMoving fm, IBoard board)
        {
            throw new NotImplementedException();
        }

        public bool CanMove(FigureMoving fm, IBoard board)
        {
            bool result = this.CanMoveFrom(fm, board) && this.CanMoveTo(fm, board) && CanFigureMove(fm, board);

            return result;
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
            ChessColor color = figure.Color;
            Position from = move.From;
            Position to = move.To;

            if (color.Equals(ChessColor.While) && to.Row < from.Row)
            {
                throw new InvalidOperationException(PownsNenNotMoveBackwards);
            }

            if (color.Equals(ChessColor.Black) && to.Row > from.Row)
            {
                throw new InvalidOperationException(PownsNenNotMoveBackwards);
            }

            if (color.Equals(ChessColor.While))
            {
                if ((from.Row + 1).Equals(to.Row) && this.CheckDiagonalMove(from, to))
                {
                    if (this.CheckOtherFigureIfValid(board, to, ChessColor.Black))
                    {
                        return;
                    }
                }
            }
            else if (color.Equals(ChessColor.Black))
            {
                if ((from.Row - 1).Equals(to.Row) && this.CheckDiagonalMove(from, to))
                {
                    if (this.CheckOtherFigureIfValid(board, to, ChessColor.While))
                    {
                        return;
                    }
                }
            }

            var fm = new FigureMoving(figure, move);
            throw new NotImplementedException();
        }

        private bool CheckOtherFigureIfValid(IBoard board, Position to, ChessColor color)
        {
            var otherFigure = board.GetFigureAtPosition(to);
            if (!(otherFigure is null) && otherFigure.Color.Equals(color))
            {
                return true;
            }

            return false;
        }

        private bool CheckDiagonalMove(Position from, Position to) => ((from.Col + 1).Equals(to.Col) || (from.Col - 1).Equals(to.Col));
    }
}
