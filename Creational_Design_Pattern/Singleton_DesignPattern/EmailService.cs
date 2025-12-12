public interface IEmailService
{
    void SendEmail(string to, string subject, string body);
}

public class EmailService : IEmailService
{
    public EmailService()
    {
        Console.WriteLine("EmailService created.");
    }

    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"\n--- Sending Email ---");
        Console.WriteLine($"To: {to}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Body: {body}");
        Console.WriteLine("--- Email Sent ---\n");
    }
}