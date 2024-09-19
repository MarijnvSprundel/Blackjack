using ConsoleCasino.Models;

namespace ConsoleCasino.Services;

public class AuthService
{
    // user table sim
    private readonly List<User> _usersTable = [
        new User("Fucker", "fucker@gmail.com", "verysafepassword")
    ];
}