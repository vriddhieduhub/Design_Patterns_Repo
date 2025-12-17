abstract class OrderProcessTemplate
{
    // Template method
    public void ProcessOrder()
    {
        ValidateOrder();
        TakePayment();
        Deliver();
        SendConfirmation();
    }

    protected void ValidateOrder()
    {
        Console.WriteLine("Order validated");
    }

    protected abstract void TakePayment();
    protected abstract void Deliver();

    // Hook (optional override)
    protected virtual void SendConfirmation()
    {
        Console.WriteLine("Confirmation sent");
    }
}
