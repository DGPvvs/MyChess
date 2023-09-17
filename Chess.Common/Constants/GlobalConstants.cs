﻿namespace Chess.Common.Constants
{
    public static class GlobalConstants
    {
        public static class BoardConstants
        {
            public const int StandartPlayersNum = 2;
            public const int StandartRows = 8;
            public const int StandartCols = 8;
        }

        public static class ErrorMessages
        {
            public const string EmptyString = "";
            public const string NullFigureErrorMessage = "Фигурата не може да е null";
            public const string OutOfRangeRow = "Избраният ред е извън дъската!";
            public const string OutOfRangeCol = "Избраната колона е извън дъската!";
            public const string PlayersAlredyHasThisFigureMessage = "Играчът вече притежава тази фигура!";
            public const string PlayersNotHasThisFigureMessage = "Играчът не притежава тази фигура!";
            public const string StandartSrategyMustTwoPlayers = "Стандартната игра трябва да има двама играчи!";
            public const string StandartSrategyMustEightRowsAndCols = "Стандартната игра трябва да има осем реда и одем колони!";
        }

        public static class Fen
        {
            public const string StandartFen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        }
    }
}
