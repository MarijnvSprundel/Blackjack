namespace Blackjack.Enums;

public enum CardSuit
{
    Clubs,
    Spades,
    Hearts,
    Diamonds
}

static class CardSuitExtensions
{
    public static string GetString(this CardSuit suit)
    {
        return suit switch
        {
            CardSuit.Clubs => "Clubs",
            CardSuit.Spades => "Spades",
            CardSuit.Hearts => "Hearts",
            CardSuit.Diamonds => "Diamonds",
            _ => throw new ArgumentOutOfRangeException(nameof(suit), suit, null)
        };
    }
}