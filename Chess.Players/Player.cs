namespace Chess.Players
{
    using Chess.Common.CommonClasses;
    using Chess.Common.Enums;
    using Chess.Figures.Contracts;
    using Chess.Players.Contracts;
    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;

    public class Player : IPlayer
    {
        private readonly IList<IFigure> figures;
        private readonly ChessColor color;

        public Player(IList<IFigure> figures, ChessColor color)
        {
            this.figures = figures;
            this.Color = color;
        }

        public Player(ChessColor color) : this(new List<IFigure>(), color)
        {            
        }

        public ChessColor Color
        {
            get => this.color;
            init => this.color = value;
        }

        public IList<IFigure> Figures => new List<IFigure>(this.figures);

        public void AddFigure(IFigure figure)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, NullFigureErrorMessage);

            if (this.CheckIfFigureExist(figure))
            {
                throw new InvalidOperationException(PlayersAlredyHasThisFigureMessage);
            }
            
            this.figures.Add(figure);
        }

        public void RemoveFigure(IFigure figure)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, NullFigureErrorMessage);

            if (!this.CheckIfFigureExist(figure))
            {
                throw new InvalidOperationException(PlayersNotHasThisFigureMessage);
            }

            this.figures.Remove(figure);
        }

        private bool CheckIfFigureExist(IFigure figure)
        {
            bool result = false;

            if (this.figures.Contains(figure))
            {
                result = true;
            }

            return result;
        }
    }
}
