using ConsoleCasino.Interfaces;
using ConsoleCasino.Models;

namespace ConsoleCasino.Games.ThreeCardPoker;

public class ThreeCardPoker : IGame
{
    public void Run(User user)
    {
        Console.WriteLine("Hello welcome to this game");
        Console.ReadKey();
    }
    
    // this shit works like so:
    //
    // 1. put in your ante bet and pair plus bet
    // 2. you give the fucker 3 cards
    // 3. dealer gets 3 cards (these stay hidden)
    // 4. the fucker views their cards and decides if they are a pussy and they fold or they play
    // 4.a hints should be added for mentally struggling fuckers who dont understand the game
    // 5. dealer starts uncovering their cards (and like always they pull some shit like a straight flush while you got a 4 high)
    // 6. we pay out or we steal
    // 7. we done
    
}