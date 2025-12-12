namespace Builder_DesignPattern
{
    public class NotificationMessage
    {
        public string Recipient { get; }
        public string Title { get; }
        public string Body { get; }
        public DateTime SendAt { get; }
        public bool IsHighPriority { get; }

        internal NotificationMessage(string recipient, string title, string body, DateTime sendAt, bool isHighPriority)
        {
            Recipient = recipient;
            Title = title;
            Body = body;
            SendAt = sendAt;
            IsHighPriority = isHighPriority;
        }

        public override string ToString()
        {
            return $@"
            Recipient: {Recipient}
            Title: {Title}
            Body: {Body}
            SendAt: {SendAt}
            HighPriority: {IsHighPriority}";
        }
    }
}
