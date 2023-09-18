namespace Chess.InputProviders
{
    using Chess.Common.ConsoleHelpers;
    using Chess.Common.Enums;
    using Chess.InputProviders.Contracts;
    using Chess.Players;
    using Chess.Players.Contracts;

    public class ConsoleInputProvider : IInputProvider
    {
        private const string PlayerNameText = "Въведете името на {0} играч: ";
        public IList<IPlayer> GetPlayers(int numberOfPlayers)
        {
            List<IPlayer> players = new List<IPlayer>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Clear();
                ConsoleHelpers.SetCursorAtCenter(PlayerNameText.Length);
                Console.Write(string.Format(PlayerNameText, i));
                string name = Console.ReadLine();

                Player player = new Player((ChessColor)(i - 1), name);

                players.Add(player);
            }

            return players;
        }
    }
}
