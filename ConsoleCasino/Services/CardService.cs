using ConsoleCasino.Models;

namespace ConsoleCasino.Services;

using ConsoleCasino.Models;

public static class CardService
{
    public static Card Random()
    {
        return new Card(CardSuitService.Random(), CardTypeService.Random());
    }
}