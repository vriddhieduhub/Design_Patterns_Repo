namespace Builder_DesignPattern
{
    public class NotificationBuilder : INotificationBuilder
    {
        private string _recipient;
        private string _title;
        private string _body;
        private DateTime _sendAt = DateTime.Now;
        private bool _isHighPriority = false;

        public INotificationBuilder To(string recipient)
        {
            _recipient = recipient;
            return this;
        }

        public INotificationBuilder WithTitle(string title)
        {
            _title = title;
            return this;
        }

        public INotificationBuilder WithBody(string body)
        {
            _body = body;
            return this;
        }

        public INotificationBuilder ScheduleAt(DateTime dateTime)
        {
            _sendAt = dateTime;
            return this;
        }

        public INotificationBuilder HighPriority()
        {
            _isHighPriority = true;
            return this;
        }

        public NotificationMessage Build()
        {
            return new NotificationMessage(_recipient, _title, _body, _sendAt, _isHighPriority);
        }
    }
}