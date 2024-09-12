namespace Blackjack.Services;

using Blackjack.Structs;

public static class CardService
{
    public static Card Random()
    {
        return new Card(CardSuitService.Random(), CardTypeService.Random());
    }
}