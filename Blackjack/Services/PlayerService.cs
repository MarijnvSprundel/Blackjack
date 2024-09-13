using Blackjack.Models;

namespace Blackjack.Services;

public static class PlayerService
{
    public static List<Player> InitializePlayers()
    {
        return Enumerable.Range(0, GetCount()).Select(n => new Player(GetName(n))).ToList();
    }

    private static int GetCount()
    {
        Console.Clear();
        Console.WriteLine("With how many players you want to play?");
        
        int? playerCount;

        do
        {
            try
            {
                playerCount = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (FormatException)
            {
                playerCount = 0;
            };
            
            if (playerCount >= 1 && playerCount <= 4) break;

            playerCount = null;
            
            Console.Clear();
            Console.WriteLine("Please enter a number between 1 and 4");
        } while (playerCount == null);
        
        return playerCount.Value;
    }

    private static string GetName(int playerNumber)
    {
        string? name;

        do
        {
            Console.Clear();
            Console.WriteLine("Please enter a name for player " + playerNumber);
                
            name = Console.ReadLine();
        } while (name == null);
        
        return name;
    }
    
    // Maybe add a method for grabbing points from a player
}