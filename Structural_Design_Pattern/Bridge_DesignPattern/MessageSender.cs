public class EmailSender : IMessageSender
{
    public void Send(string subject, string body)
    {
        Console.WriteLine($"[EMAIL]\nSubject: {subject}\nMessage: {body}\n");
    }
}

public class SmsSender : IMessageSender
{
    public void Send(string subject, string body)
    {
        Console.WriteLine($"[SMS]\nTo: (subject ignored)\nMessage: {body}\n");
    }
}

public class WhatsAppSender : IMessageSender
{
    public void Send(string subject, string body)
    {
        Console.WriteLine($"[WHATSAPP]\nSubject: {subject}\nMessage: {body}\n");
    }
}
