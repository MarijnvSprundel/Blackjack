using ConsoleCasino.Models;
using ConsoleCasino.Enums;
using ConsoleCasino.Games.Blackjack.Models;

namespace ConsoleCasino.Games.Blackjack.Services;

public static class BlackjackService
{
    public static double GetWinnings(Cards playerCards, Cards dealerCards)
    {
        if (playerCards.Busted) return 0;
        if (dealerCards.Busted) return playerCards.Points * 1.5;
        
        var playerCardsValue = playerCards.GetValue();
        var dealerCardsValue = dealerCards.GetValue();

        if (playerCardsValue == dealerCardsValue) return playerCards.Points;
        
        return playerCardsValue > dealerCardsValue ? playerCards.Points * 1.5 : 0;
    }
}