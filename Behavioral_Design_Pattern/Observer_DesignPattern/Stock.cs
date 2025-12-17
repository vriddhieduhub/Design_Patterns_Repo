//Concrete Subject
class Stock : IStock
{
    private readonly List<IInvestor> _investors = new();
    private decimal _price;

    public string Name { get; }

    public Stock(string name)
    {
        Name = name;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
        Notify();
    }

    public void Register(IInvestor investor)
    {
        _investors.Add(investor);
    }

    public void Unregister(IInvestor investor)
    {
        _investors.Remove(investor);
    }

    public void Notify()
    {
        foreach (var investor in _investors)
        {
            investor.Update(Name, _price);
        }
    }
}
