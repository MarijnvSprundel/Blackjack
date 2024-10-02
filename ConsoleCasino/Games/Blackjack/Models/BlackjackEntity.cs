using ConsoleCasino.Games.Blackjack.Models;

namespace ConsoleCasino.Games.Blackjack.Interfaces;

public abstract class BlackjackEntity {
    public List<Cards> CardSets = [];

    private int _activeCardSet = 0;
    
    public override string ToString() => Prefix() + "Entity";

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

    public string Prefix()
    {
        return string.Empty;
    }
}