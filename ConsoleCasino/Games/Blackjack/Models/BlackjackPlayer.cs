using ConsoleCasino.Games.Blackjack.Interfaces;
using ConsoleCasino.Models;

namespace ConsoleCasino.Games.Blackjack.Models;

public class BlackjackPlayer(User user) : BlackjackEntity {
    public User User = user;
    
    public override string ToString() => Prefix() + User.Name;
}