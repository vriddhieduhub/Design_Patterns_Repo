class NewOrderState : IOrderState
{
    public void Next(OrderContext context)
    {
        Console.WriteLine("Order paid");
        context.SetState(new PaidState());
    }

    public void Cancel(OrderContext context)
    {
        Console.WriteLine("Order cancelled");
    }
}

class PaidState : IOrderState
{
    public void Next(OrderContext context)
    {
        Console.WriteLine("Order shipped");
        context.SetState(new ShippedState());
    }

    public void Cancel(OrderContext context)
    {
        Console.WriteLine("Refund issued");
    }
}

class ShippedState : IOrderState
{
    public void Next(OrderContext context)
    {
        Console.WriteLine("Order delivered");
        context.SetState(new DeliveredState());
    }

    public void Cancel(OrderContext context)
    {
        Console.WriteLine("Cannot cancel, already shipped");
    }
}

class DeliveredState : IOrderState
{
    public void Next(OrderContext context)
    {
        Console.WriteLine("Order already delivered");
    }

    public void Cancel(OrderContext context)
    {
        Console.WriteLine("Cannot cancel, already delivered");
    }
}
