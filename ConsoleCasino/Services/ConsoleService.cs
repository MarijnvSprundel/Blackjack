namespace ConsoleCasino.Services;

public class ConsoleService
{
    public static void AnyKeyToContinue()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}