using ConsoleCasino.Interfaces;
using ConsoleCasino.Models;

namespace ConsoleCasino.Games.SlotMachine;

public class SlotMachine : IGame
{
    public void Run(List<User> players)
    {
        Console.WriteLine("Welcome to the slot mochine");
        Console.ReadKey();
    }
}