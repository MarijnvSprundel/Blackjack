using Blackjack.Enums;

namespace Blackjack.Models;

public class Deck
{
    // This struct will contain 52 card instances
    // Will have function grab
    // but is it better to remove grabbed cards or mark them? IRL if a card is grabbed from the deck well it aint in the deck no more
    // so just remove it from deck
    // makes shit a lot easier since we dont have to filter the list to only get actual cards
    // 
    // Methods:
    // Grab() => Grabs first card from the deck
    // Shuffle() => Shuffles the deck
    // Constructor will add 52 cards to deck, none of them duplicate

    public Deck()
    {
        foreach(CardSuit suit in Enum.GetValues(typeof(CardSuit)))
        {
            foreach(CardType type in Enum.GetValues(typeof(CardType)))
            {
                _cards.Add(new Card(suit, type));
            }
        }
    }

    private List<Card> _cards = new List<Card>();
    private static Random _random = new Random();

    public void Shuffle()
    {
        _cards = _cards.OrderBy(x => _random.Next()).ToList();
    }

    public Card Draw()
    {
        var card = _cards[0];
        _cards.RemoveAt(0);
        
        return card;
    }
    
    public int Length => _cards.Count;
}