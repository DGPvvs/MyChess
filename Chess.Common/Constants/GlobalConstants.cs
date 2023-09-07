namespace Chess.Common.Constants
{
    public static class GlobalConstants
    {
        public static class BoardConstants
        {
            public const int StandartRows = 8;
            public const int StandartCols = 8;
        }

        public static class ErrorMessages
        {
            public const string EmptyString = "";
            public const string NullFigureErrorMessage = "Фигурата не може да е null";
            public const string OutOfRangeRow = "Избраният ред е извън дъската!";
            public const string OutOfRangeCol = "Избраната колона е извън дъската!";
        }
    }
}
