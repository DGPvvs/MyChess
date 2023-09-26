namespace Chess.InputProviders
{
    using Chess.Common.CommonClasses;
    using Chess.Common.ConsoleHelpers;
    using Chess.Common.Enums;
    using Chess.InputProviders.Contracts;
    using Chess.Players;
    using Chess.Players.Contracts;
    using Chess.Renderers;

    public class ConsoleInputProvider : IInputProvider
    {
        private const string PlayerNameText = "Въведете името на {0} играч: ";

        public Move GetNextPlayerMove(IPlayer player)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Следващ ход на {0}: ", player.Name);

            string positionAsString = Console.ReadLine().Trim().ToLower();

            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, 0);

            Move move = ConsoleRendererHelper.CreatedMoveFromCommand(positionAsString);
            return move;
        }

        public IList<IPlayer> GetPlayers(int numberOfPlayers)
        {
            List<IPlayer> players = new List<IPlayer>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Clear();
                ConsoleHelpers.SetCursorAtCenter(PlayerNameText.Length);
                Console.Write(string.Format(PlayerNameText, i));
                string name = Console.ReadLine();

                Player player = new Player((ChessColor)(i), name);

                players.Add(player);
            }

            return players;
        }
    }
}
