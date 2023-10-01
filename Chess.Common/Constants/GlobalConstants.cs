namespace Chess.Common.Constants
{
    public static class GlobalConstants
    {
        public static class BoardConstants
        {
            public const int StandartPlayersNum = 2;
            public const int StandartRows = 8;
            public const int StandartCols = 8;
            public const int MinimumRowValueOnBoard = 1;
            public const int MaximumRowValueOnBoard = 8;
            public const char MinimumColValueOnBoard = 'a';
            public const char MaximumColValueOnBoard = 'h';

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
            public const string InvaldColor = "Невалиден цвят!";
            public const string InvaldCommand = "Невалидна команда!";
            public const string FromPositionIsEmpty = "Позиция {0}{1} е празна!";
            public const string AlresdyHaveYourFigureAtPosition = "Вече има ваша фигура на позиция {0}{1}!";
            public const string ThisFigureIsNotYours = "Фигурата на позиция {0}{1} не е ваша!";
            public const string PownsNenNotMoveBackwards = "Пешките не могат да се движат назад!";
        }

        public static class Fen
        {
            public const string StandartFen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        }

        public static class ConsoleRendererConstants
        {
            public const int CharactersPerRowBoardSquare = 9;
            public const int CharactersPerColBoardSquare = 9;

            public const ConsoleColor DarkSquareConsoleColor = ConsoleColor.DarkCyan;
            public const ConsoleColor LightSquareConsoleColor = ConsoleColor.DarkGray;
        }
    }
}
