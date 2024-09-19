using System;
using System.Text.RegularExpressions;
using Blackjack.Enums;
using Blackjack.Factories;
using Blackjack.Models;
using Blackjack.Services;
using BlackjackGame = Blackjack.Games.Blackjack.Blackjack;

namespace Blackjack
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