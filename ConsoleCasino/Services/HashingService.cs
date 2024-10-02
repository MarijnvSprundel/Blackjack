using System.Security.Cryptography;
using System.Text;

namespace ConsoleCasino.Services;

public class HashingService
{
    private const int KeySize = 64;
    private const int Iterations = 350000;

    public static string HashPassword(string password, out byte[] salt)
    {
        salt = GenerateSalt();

        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            salt,
            Iterations,
            HashAlgorithmName.SHA512,
            KeySize
        );
        
        return Convert.ToHexString(hash);
    }

    public static bool VerifyPassword(string password, string hash, byte[] salt)
    {
        Console.WriteLine(password);
        Console.WriteLine(hash);

        Console.WriteLine(salt);

        var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA512, KeySize);
        
        return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
    }

    public static byte[] GenerateSalt()
    {
        return RandomNumberGenerator.GetBytes(KeySize);
    }
}