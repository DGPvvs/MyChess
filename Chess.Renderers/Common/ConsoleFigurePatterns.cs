﻿namespace Chess.Renderers.Common
{
    public static class ConsoleFigurePatterns
    {
        public enum ElementEnum
        {
            T = '*',
            F = ' '
        }

        public static readonly char[,] pawnPattern = new char[9, 9]
        {
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
        };

        public static readonly char[,] rookPattern = new char[9, 9]
        {
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', '*', ' ', '*', ' ', '*', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
            { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
        };

        public static readonly char[,] knightPattern = new char[9, 9]
        {
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', '*', ' ', '*', ' ', ' ' },
            { ' ', ' ', '*', '*', ' ', '*', '*', ' ', ' ' },
            { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', '*', '*', ' ', ' ' },
            { ' ', ' ', ' ', ' ', '*', '*', '*', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
        };

        public static readonly char[,] bishopPattern = new char[9, 9]
        {
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', ' ', '*', '*', ' ', '*', '*', ' ', ' ' },
            { ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ' },
            { ' ', ' ', ' ', '*', ' ', '*', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
            { ' ', '*', '*', '*', ' ', '*', '*', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
        };

        public static readonly char[,] queenPattern = new char[9, 9]
        {
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
            { ' ', ' ', '*', ' ', '*', ' ', '*', ' ', ' ' },
            { ' ', ' ', ' ', '*', ' ', '*', ' ', ' ', ' ' },
            { ' ', '*', ' ', '*', '*', '*', ' ', '*', ' ' },
            { ' ', ' ', '*', ' ', '*', ' ', '*', ' ', ' ' },
            { ' ', ' ', '*', '*', ' ', '*', '*', ' ', ' ' },
            { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
        };

        public static readonly char[,] kingPattern = new char[9, 9]
        {
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
            { ' ', '*', '*', ' ', '*', ' ', '*', '*', ' ' },
            { ' ', '*', '*', '*', ' ', '*', '*', '*', ' ' },
            { ' ', '*', '*', '*', '*', '*', '*', '*', ' ' },
            { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
            { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
        };
    }
}
