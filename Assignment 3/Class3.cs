public static class Logger
{
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

class LoggerApp
{
    static void Main()
    {
        Logger.LogMessage("Application started.");
    }
}
