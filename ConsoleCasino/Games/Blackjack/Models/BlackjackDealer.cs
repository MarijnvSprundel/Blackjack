using ConsoleCasino.Games.Blackjack.Interfaces;
using ConsoleCasino.Models;

namespace ConsoleCasino.Games.Blackjack.Models;

public class BlackjackDealer(string name) : BlackjackEntity {
    public override string ToString() => Prefix() + "Dealer";
}