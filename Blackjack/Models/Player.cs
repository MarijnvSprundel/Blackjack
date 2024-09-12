namespace Blackjack.Models;

public class Player(string name)
{
    public string Name { get; init; } = name;
    public int Points { get; set; } = 1000;
}