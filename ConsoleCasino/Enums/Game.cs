namespace ConsoleCasino.Enums;

public enum Game
{
    Blackjack,
    ThreeCardPoker
}

public static class EnumExtensions
{
    public static string GetString(this Game game)
    {
        return game switch
        {
            Game.Blackjack => "Blackjack",
            Game.ThreeCardPoker => "Three Card Poker",
            _ => "What the flip"
        };
    }
}