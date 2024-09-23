using ConsoleCasino.Models;

namespace ConsoleCasino.Services;

public class AuthService
{
    private List<User> _usersTable =
    [
    ];

    public void InitDB()
    {
        var password = HashingService.HashPassword("password", out var salt);
        
        _usersTable.Add(
            new User("Fucker", "fucker@gmail.com", password, salt.ToString())
        );
    }

    public bool ValidateCredentials(string email, string password)
    {
        var user = _usersTable.FirstOrDefault(u => u.Email == email);
        if (user?.Password == null || user.PasswordSalt == null) return false;
        return HashingService.VerifyPassword(password, user.Password, user.PasswordSalt);
    }
}