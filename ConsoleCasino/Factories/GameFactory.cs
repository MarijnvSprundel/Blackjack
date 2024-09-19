using ConsoleCasino.Enums;
using ConsoleCasino.Games.ThreeCardPoker;
using ConsoleCasino.Interfaces;

namespace ConsoleCasino.Factories;

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