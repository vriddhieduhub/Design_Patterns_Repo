public class SmsAdapter : INotificationSender
{
    private readonly ThirdPartySmsService _smsService;

    public SmsAdapter(ThirdPartySmsService smsService)
    {
        _smsService = smsService;
    }

    public void Send(string to, string message)
    {
        // Adapting method signature
        _smsService.SendSmsToPhone(to, message);
    }
}
