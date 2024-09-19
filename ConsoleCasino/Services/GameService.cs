using ConsoleCasino.Enums;

namespace ConsoleCasino.Services;

public static class GameService
{
    public static Game SelectGame()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("What game would you like to play?\n");

            foreach (Game game in Enum.GetValues(typeof(Game)))
            {
                Console.WriteLine(game.GetHashCode() + ": " + game.GetString());
            }

            int input = -1;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                // ignored
            }

            Game? chosenGame = Enum.IsDefined(typeof(Game), input) ? (Game)input : null;

            if (chosenGame != null) return (Game)chosenGame;

            Console.WriteLine("Invalid input, please try again.\n");
            ConsoleService.AnyKeyToContinue();
        }
    }
}