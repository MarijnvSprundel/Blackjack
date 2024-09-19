using ConsoleCasino.Models;

namespace ConsoleCasino.Games.Blackjack.Models;

public class BlackjackUser(string name, string email, string password) : User(name, email, password)
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