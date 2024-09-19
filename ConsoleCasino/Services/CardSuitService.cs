using ConsoleCasino.Enums;

namespace ConsoleCasino.Services;

using ConsoleCasino.Enums;

public class CardSuitService
{
    public static CardSuit Random()
    {
        Array values = Enum.GetValues(typeof(CardSuit));
        
        return (CardSuit?)values.GetValue(new Random().Next(values.Length))
               ?? throw new ArgumentOutOfRangeException();
    }
}