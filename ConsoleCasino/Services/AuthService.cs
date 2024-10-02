using ConsoleCasino.Models;

namespace ConsoleCasino.Services;

public class AuthService {
    public AuthService() {
        InitDb();
    }
    
    private List<User> _usersTable = [
    ];
    
    public void InitDb() {
        var password = HashingService.HashPassword("password", out var salt);
        _usersTable.Add(
            new User("Fucker", "fucker@gmail.com", password, salt.ToString())
        );
    }

    private User? GetUser(string email, string password) {
        var user = _usersTable.FirstOrDefault(u => u.Email == email);
        if (user == null) return null;
        
        return HashingService.VerifyPassword(password, user.Password, user.PasswordSalt) ? user : null;
    }

    public User Login() {
        while (true) {
            Console.Clear();
            Console.WriteLine("Please enter your email:");
            var email = Console.ReadLine();
        
            Console.Clear();
            Console.WriteLine("Please enter your password:");
            var password = Console.ReadLine();

            var user = email != null && password != null ? GetUser(email, password) : null;
                    
            if (user != null) return user;
            
            Console.WriteLine("Incorrect email or password");
            Console.ReadKey();
        }
    }
}