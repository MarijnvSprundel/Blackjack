namespace ConsoleCasino.Models;

public class User(string name, string email, string password)
{
    public string Name { get; init; } = name;
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
    public double Points { get; set; } = 1000f;
}