using ConsoleCasino.Enums;

namespace ConsoleCasino.Services;

using ConsoleCasino.Enums;

public class CardTypeService
{
    public static CardType Random()
    {
        Array values = Enum.GetValues(typeof(CardType));
        
        return (CardType?)values.GetValue(new Random().Next(values.Length))
               ?? throw new ArgumentOutOfRangeException();
    }
}