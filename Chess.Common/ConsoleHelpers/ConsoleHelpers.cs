namespace Chess.Common.ConsoleHelpers
{
    public static class ConsoleHelpers
    {
        public static void SetCursorAtCenter(int lengthOfMessage)
        {
            int cenrerRow = Console.WindowHeight / 2;
            int centralCol = (Console.WindowWidth - lengthOfMessage) / 2;

            Console.SetCursorPosition(centralCol, cenrerRow);
        }        
    }    
}
