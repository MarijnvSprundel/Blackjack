using Blackjack.Models;

namespace Blackjack.Games.Blackjack.Models;

public class BlackjackPlayer(string name) : Player(name)
{
    public List<Card> Cards { get; set; } = [];

    public bool Stood { get; set; } = false;
    
    public bool DoubledDown { get; set; } = false;
    
    public bool Busted { get; set; } = false;

    public override string ToString() => Prefix() + Name;

    private string Prefix()
    {
        return Busted ? "(Busted) " : string.Empty;
    }
}