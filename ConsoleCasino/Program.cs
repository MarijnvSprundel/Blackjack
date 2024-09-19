using System;
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