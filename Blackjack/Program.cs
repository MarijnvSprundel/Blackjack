using System;
using Blackjack.Services;
using BlackjackGame = Blackjack.Games.Blackjack.Blackjack;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playerPool = PlayerService.InitializePlayers();
            
            new BlackjackGame(playerPool).Run();
        }
    }
}