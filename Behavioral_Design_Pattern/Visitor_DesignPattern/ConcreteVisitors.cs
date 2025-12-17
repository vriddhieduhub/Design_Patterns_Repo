class TaxVisitor : IVisitor
{
    public decimal TotalTax { get; private set; }

    public void Visit(Book book)
    {
        TotalTax += book.Price * 0.10m; // 10% tax
    }

    public void Visit(Food food)
    {
        TotalTax += food.Price * 0.05m; // 5% tax
    }
}
