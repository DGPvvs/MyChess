namespace Chess.Renderers.Common
{
    public static class ConsoleFigurePatterns
    {
        public enum ElementEnum
        {
            T = 0,
            F = 1
        }

        public static readonly ElementEnum[,] pawnPattern = new ElementEnum[ 9, 9 ]
        {
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
        };

        public static readonly ElementEnum[,] rookPattern = new ElementEnum[9, 9]
        {
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
        };

        public static readonly ElementEnum[,] knightPattern = new ElementEnum[9, 9]
        {
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
        };

        public static readonly ElementEnum[,] bishopPattern = new ElementEnum[9, 9]
        {
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.T, ElementEnum.F, ElementEnum.F},
            {ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F, ElementEnum.F},
        };
    }
}
