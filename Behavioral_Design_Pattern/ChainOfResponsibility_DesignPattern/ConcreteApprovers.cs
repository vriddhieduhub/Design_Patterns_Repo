class Manager : ExpenseApprover
{
    public override void Approve(decimal amount)
    {
        if (amount <= 10000)
            Console.WriteLine($"Manager approved ₹{amount}");
        else
            _next?.Approve(amount);
    }
}

class Director : ExpenseApprover
{
    public override void Approve(decimal amount)
    {
        if (amount <= 50000)
            Console.WriteLine($"Director approved ₹{amount}");
        else
            _next?.Approve(amount);
    }
}

class CEO : ExpenseApprover
{
    public override void Approve(decimal amount)
    {
        Console.WriteLine($"CEO approved ₹{amount}");
    }
}
