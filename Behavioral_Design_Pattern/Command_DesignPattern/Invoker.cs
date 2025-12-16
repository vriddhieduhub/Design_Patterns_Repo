class Waiter
{
    private readonly List<IOrderCommand> _orders = new();

    public void TakeOrder(IOrderCommand order)
    {
        _orders.Add(order);
    }

    public void PlaceOrders()
    {
        foreach (var order in _orders)
            order.Execute();
    }
}
