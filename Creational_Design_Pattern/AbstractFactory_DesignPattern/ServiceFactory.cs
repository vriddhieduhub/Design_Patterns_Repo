public abstract class ServiceFactory
{
    public abstract INotification CreateNotification();
    public abstract ILogger CreateLogger();
}

public class EmailServiceFactory : ServiceFactory
{
    public override INotification CreateNotification() => new EmailNotification();
    public override ILogger CreateLogger() => new EmailLogger();
}


public class SmsServiceFactory : ServiceFactory
{
    public override INotification CreateNotification() => new SmsNotification();
    public override ILogger CreateLogger() => new SmsLogger();
}
