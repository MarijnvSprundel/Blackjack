namespace ConsoleCasino.Services;

public static class ConsoleService
{
    public static void AnyKeyToContinue()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}