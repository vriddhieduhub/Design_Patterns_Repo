using Factory_DesignPattern;

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }
}