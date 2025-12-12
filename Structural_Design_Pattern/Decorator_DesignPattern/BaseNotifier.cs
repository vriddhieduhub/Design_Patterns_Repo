// 2. ConcreteComponent
public class BasicNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending basic notification: {message}");
    }
}
