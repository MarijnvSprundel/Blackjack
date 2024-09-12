using Blackjack.Enums;
using Blackjack.Services;

namespace Blackjack.Structs;

public struct Card
{
    public Card(CardSuit suit, CardType type)
    {
        Suit = suit;
        Type = type;
    }
    
    public CardSuit Suit { get; init; }
    public CardType Type { get; init; }

    public override string ToString()
    {
        return Suit.GetString() + " " + Type.GetString();
    }
}