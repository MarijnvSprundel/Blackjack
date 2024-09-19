using Blackjack.Enums;
using Blackjack.Games.ThreeCardPoker;
using Blackjack.Interfaces;

namespace Blackjack.Factories;

public class GameFactory
{
    public static IGame CreateGame(Game game)
    {
        return game switch
        {
            Game.Blackjack => new Games.Blackjack.Blackjack(),
            Game.ThreeCardPoker => new ThreeCardPoker(),
            _ => throw new NotImplementedException(),
        };
    }
}