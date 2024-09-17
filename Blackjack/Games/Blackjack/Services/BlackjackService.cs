using Blackjack.Models;
using Blackjack.Enums;
using Blackjack.Games.Blackjack.Models;

namespace Blackjack.Games.Blackjack.Services;

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