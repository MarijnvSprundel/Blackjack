using System.Text;

namespace ConsoleCasino.Models;

public class User(string name, string email, string password, string passwordSalt)
{
    public string Name { get; init; } = name;
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
    public byte[] PasswordSalt { get; set; } = Encoding.UTF8.GetBytes(passwordSalt);
    public double Points { get; set; } = 1000f;
}