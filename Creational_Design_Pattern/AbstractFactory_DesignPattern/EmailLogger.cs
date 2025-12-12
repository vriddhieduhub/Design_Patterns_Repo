public class EmailLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Email Log: " + message);
    }
}