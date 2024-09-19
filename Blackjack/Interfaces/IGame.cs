using Blackjack.Models;

namespace Blackjack.Interfaces;

public interface IGame
{
    public void Run(List<Player> players);
}