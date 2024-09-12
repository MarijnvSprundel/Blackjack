using System;
using Blackjack.Services;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to gambling!");
            
            
            Console.WriteLine("Dealer has ");
            
            // Blackjack explained
            // u get like two cards
            // dealer gets two cards
            // dealer has one card visible one card not
            // u can see your whole 2 cards
            // choose to stand/hit/double down
            // when you go above 21 you bust
            
            // when you have exactly 21 you just continue
            // below you can always hit
            // double down is only available on ur first turn i think
            // when you stand the dealer will start grabbing cards until they are above 17
            
            // ace has two values, 1 and 11. When 11 would make your value above 21 it becomes 1
            
            // so program is 
            // 1. start
            // 2. show cards of user and dealer
            // 3. let user decide
            // 4. if user is still under 21 and hasn't standed down yet let em do another choice
            // 5. make dealer start grabbing cards
            // 6. check if user or dealer has won
            
            // when we finish, add value system
            // Move code written here to seperate Blackjack class so we can also start on three card poker
            // then goo goo ga ga
            
            
        }
    }
}