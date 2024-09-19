using ConsoleCasino.Enums;
using ConsoleCasino.Games.SlotMachine;
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
            Game.SlotMachine => new SlotMachine(),
            _ => throw new NotImplementedException(),
        };
    }
}