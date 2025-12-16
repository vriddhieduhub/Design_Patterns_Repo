class ChannelCollection : IChannelCollection
{
    private readonly List<string> _channels = new();

    public void AddChannel(string channel)
    {
        _channels.Add(channel);
    }

    public IIterator<string> CreateIterator()
    {
        return new ChannelIterator(_channels);
    }
}
