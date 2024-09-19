namespace ConsoleCasino.Enums;

public enum CardType
{
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace
}

static class CardTypeExtensions
{
    public static string GetString(this CardType type)
    {
        return type switch
        {
            CardType.Two => "2",
            CardType.Three => "3",
            CardType.Four => "4",
            CardType.Five => "5",
            CardType.Six => "6",
            CardType.Seven => "7",
            CardType.Eight => "8",
            CardType.Nine => "9",
            CardType.Ten => "10",
            CardType.Jack => "J",
            CardType.Queen => "Q",
            CardType.King => "K",
            CardType.Ace => "A",
        };
    }
}