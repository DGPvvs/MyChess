namespace Chess.Players
{
    using Chess.Board.Figures.Contracts;
    using Chess.Common.CommonClasses;
    using Chess.Common.Enums;
    using Chess.Players.Contracts;

    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;

    public class Player : IPlayer
    {
        private readonly IList<IFigure> figures;
        private readonly ChessColor color;
        private readonly string name;

        public Player(IList<IFigure> figures, ChessColor color, string name)
        {
            this.figures = figures;
            this.Color = color;
            this.name = name;
        }

        public Player(ChessColor color, string name) : this(new List<IFigure>(), color, name)
        {            
        }

        public ChessColor Color
        {
            get => this.color;
            init => this.color = value;
        }

        public IList<IFigure> Figures => new List<IFigure>(this.figures);

        public string Name => this.name;

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
