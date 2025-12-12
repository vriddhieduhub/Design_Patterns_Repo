namespace Builder_DesignPattern
{
    public interface INotificationBuilder
    {
        INotificationBuilder To(string recipient);
        INotificationBuilder WithTitle(string title);
        INotificationBuilder WithBody(string body);
        INotificationBuilder ScheduleAt(DateTime dateTime);
        INotificationBuilder HighPriority();

        NotificationMessage Build();
    }
}