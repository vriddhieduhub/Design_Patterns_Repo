class OnlineOrder : OrderProcessTemplate
{
    protected override void TakePayment()
    {
        Console.WriteLine("Payment via Online Gateway");
    }

    protected override void Deliver()
    {
        Console.WriteLine("Delivered via Courier");
    }
}

class StorePickupOrder : OrderProcessTemplate
{
    protected override void TakePayment()
    {
        Console.WriteLine("Payment at Store Counter");
    }

    protected override void Deliver()
    {
        Console.WriteLine("Picked up from Store");
    }
}
