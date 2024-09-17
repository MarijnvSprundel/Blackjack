using Blackjack.Models;

namespace Blackjack.Games.Blackjack.Models;

public class BlackjackPlayer(string name) : Player(name)
{
    public List<Cards> CardSets = [];

    private int _activeCardSet = 0;

    public override string ToString() => Prefix() + Name;

    public Cards Cards() => CardSets[_activeCardSet];

    public void NextCardSet()
    {
        if (Cards().Count == 0) return;

        if (CardSets.ElementAtOrDefault(_activeCardSet + 1) == null)
        {
            _activeCardSet = 0;
            return;
        }
        
        _activeCardSet++;
    }

    private string Prefix()
    {
        return string.Empty;
    }
}