namespace ConsoleCasino.Enums;

public enum Game
{
    Blackjack,
    ThreeCardPoker,
    SlotMachine
}

public static class EnumExtensions
{
    public static string GetString(this Game game)
    {
        return game switch
        {
            Game.Blackjack => "Blackjack",
            Game.ThreeCardPoker => "Three Card Poker",
            Game.SlotMachine => "Slot Machine",
            _ => "What the flip"
        };
    }
}