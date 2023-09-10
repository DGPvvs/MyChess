namespace Chess.Common.Enums
{
    [Flags]
    public enum WhinResult
    {
        None = 0x00000000,
        Pat = 0x00000001,
        While = 0x00000002,
        Black = 0x00000004
    }
}
