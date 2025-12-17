class OrderContext
{
    private IOrderState _state = new NewOrderState();

    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public void Next()
    {
        _state.Next(this);
    }

    public void Cancel()
    {
        _state.Cancel(this);
    }
}
