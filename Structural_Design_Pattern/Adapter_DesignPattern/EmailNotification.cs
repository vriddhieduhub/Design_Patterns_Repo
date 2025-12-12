public class EmailNotification : INotificationSender
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"Email Sent To: {to}\nMessage: {message}\n");
    }
}