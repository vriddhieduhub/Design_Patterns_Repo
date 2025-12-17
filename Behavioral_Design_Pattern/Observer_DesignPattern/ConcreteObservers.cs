class MobileApp : IInvestor
{
    public void Update(string stock, decimal price)
    {
        Console.WriteLine($"[Mobile] {stock} price updated to ₹{price}");
    }
}

class EmailService : IInvestor
{
    public void Update(string stock, decimal price)
    {
        Console.WriteLine($"[Email] {stock} price updated to ₹{price}");
    }
}
