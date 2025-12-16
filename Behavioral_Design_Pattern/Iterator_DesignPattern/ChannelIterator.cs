class ChannelIterator : IIterator<string>
{
    private readonly List<string> _channels;
    private int _index = 0;

    public ChannelIterator(List<string> channels)
    {
        _channels = channels;
    }

    public bool HasNext()
    {
        return _index < _channels.Count;
    }

    public string Next()
    {
        return _channels[_index++];
    }
}
