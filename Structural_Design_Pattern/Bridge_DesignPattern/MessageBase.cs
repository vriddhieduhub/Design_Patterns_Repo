public abstract class MessageBase
{
    protected readonly IMessageSender _sender;

    protected MessageBase(IMessageSender sender)
    {
        _sender = sender;  // 💡 THIS IS THE BRIDGE
    }

    public abstract void SendMessage(string content);
}
