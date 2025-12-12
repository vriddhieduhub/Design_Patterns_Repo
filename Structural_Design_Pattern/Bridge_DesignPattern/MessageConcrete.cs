public class ShortMessage : MessageBase
{
    public ShortMessage(IMessageSender sender) : base(sender) { }

    public override void SendMessage(string content)
    {
        if (content.Length > 50)
            Console.WriteLine("ShortMessage Error: Content too long!");

        _sender.Send("Short Message", content);
    }
}

public class LongMessage : MessageBase
{
    public LongMessage(IMessageSender sender) : base(sender) { }

    public override void SendMessage(string content)
    {
        _sender.Send("Long Message", content);
    }
}
