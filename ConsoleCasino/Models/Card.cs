using ConsoleCasino.Services;
using ConsoleCasino.Enums;

namespace ConsoleCasino.Models;

public class Card
{
    public Card(CardSuit suit, CardType type)
    {
        Suit = suit;
        Type = type;
    }
    
    public CardSuit Suit { get; init; }
    public CardType Type { get; init; }

    public bool Hidden = false;

    public override string ToString()
    {
        return Hidden ? "****" : Suit.GetString() + " " + Type.GetString();
    }
}