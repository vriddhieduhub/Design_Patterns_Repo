// Cannot be modified (3rd party, library-based)
public class ThirdPartySmsService
{
    public void SendSmsToPhone(string phoneNumber, string text)
    {
        Console.WriteLine($"SMS Sent To: {phoneNumber}\nText: {text}\n");
    }
}