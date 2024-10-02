using System.Text;

namespace ConsoleCasino.Models;

public class Player(User user)
{
    public User User { get; init; } = user;
    public double Points { get; set; } = 1000f;
}