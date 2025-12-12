public class SmsLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("SMS Log: " + message);
    }
}
