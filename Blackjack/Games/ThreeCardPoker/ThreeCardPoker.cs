using Blackjack.Interfaces;
using Blackjack.Models;

namespace Blackjack.Games.ThreeCardPoker;

public class ThreeCardPoker : IGame
{
    public void Run(List<Player> players)
    {
        Console.WriteLine("Hello welcome to this game");
        Console.ReadKey();
    }
}