using Blackjack.Enums;
using Blackjack.Models;

namespace Blackjack.Games.Blackjack.Models;

public class Cards(IEnumerable<Card> cards, double points = 0) : List<Card>(cards)
{
    public double Points = points;
    
    public bool Stood { get; set; } = false;
    
    public bool DoubledDown { get; set; } = false;
    
    public bool Busted { get; set; } = false;

    public int GetValue()
    {
        var value = this.Aggregate(0, (current, card) => current + card.Type switch
        {
            CardType.Two => 2,
            CardType.Three => 3,
            CardType.Four => 4,
            CardType.Five => 5,
            CardType.Six => 6,
            CardType.Seven => 7,
            CardType.Eight => 8,
            CardType.Nine => 9,
            CardType.Ten => 10,
            CardType.Jack => 10,
            CardType.Queen => 10,
            CardType.King => 10,
            CardType.Ace => 0,
            _ => 0
        });
        
        var aces = this.Count(card => card.Type == CardType.Ace);
        for (var i = 0; i < aces; i++)
        {
            value += value + 11 > 21 ? 1 : 11;
        }

        return value;
    }
}