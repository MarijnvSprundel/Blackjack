using ConsoleCasino.Interfaces;
using ConsoleCasino.Models;

namespace ConsoleCasino.Games.ThreeCardPoker;

public class ThreeCardPoker : IGame
{
    public void Run(List<Player> players)
    {
        Console.WriteLine("Hello welcome to this game");
        Console.ReadKey();
    }
}