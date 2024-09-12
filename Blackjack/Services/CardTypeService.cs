namespace Blackjack.Services;

using Blackjack.Enums;

public static class CardTypeService
{
    public static CardType Random()
    {
        Array values = Enum.GetValues(typeof(CardType));
        
        return (CardType?)values.GetValue(new Random().Next(values.Length))
               ?? throw new ArgumentOutOfRangeException();
    }
}