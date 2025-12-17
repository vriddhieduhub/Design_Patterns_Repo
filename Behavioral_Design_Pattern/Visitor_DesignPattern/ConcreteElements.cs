class Book : IItem
{
    public decimal Price { get; }

    public Book(decimal price)
    {
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

class Food : IItem
{
    public decimal Price { get; }

    public Food(decimal price)
    {
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
