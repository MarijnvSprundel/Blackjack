using System;
using System.Numerics;
using System.Text.RegularExpressions;
using ConsoleCasino.Enums;
using ConsoleCasino.Models;
using ConsoleCasino.Factories;
using ConsoleCasino.Services;
using BlackjackGame = ConsoleCasino.Games.Blackjack.Blackjack;

namespace ConsoleCasino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = PlayerService.InitializePlayers();
            
            
            var game = GameService.SelectGame();

            GameFactory.CreateGame(game).Run(players);
        }
    }
}

// menu system
// 1. login screen / register
// 2. main menu (play games, view profile, exit)
// 3. play games -> game selector (already implemented)
// 4. 