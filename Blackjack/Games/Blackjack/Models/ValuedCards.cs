using Blackjack.Models;

namespace Blackjack.Games.Blackjack.Models;

public class ValuedCards(IEnumerable<Card> cards, int value = 0) : List<Card>(cards)
{
    public int Value = value;
    
    public bool Stood { get; set; } = false;
    
    public bool DoubledDown { get; set; } = false;
    
    public bool Busted { get; set; } = false;
}