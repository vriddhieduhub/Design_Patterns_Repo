using Factory_DesignPattern;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}
