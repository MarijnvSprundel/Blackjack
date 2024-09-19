using ConsoleCasino.Models;

namespace ConsoleCasino.Interfaces;

public interface IGame
{
    public void Run(List<User> players);
}