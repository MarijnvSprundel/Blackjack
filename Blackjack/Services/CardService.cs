namespace Blackjack.Services;

using Blackjack.Models;

public static class CardService
{
    public static Card Random()
    {
        return new Card(CardSuitService.Random(), CardTypeService.Random());
    }
}