//🍔 2. Leaf — Menu Item
public class MenuItem : IMenuComponent
{
    public string Name { get; }
    public decimal Price { get; }

    public MenuItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void Display(int indent = 0)
    {
        Console.WriteLine(new string(' ', indent) + $"- {Name} : ₹{Price}");
    }
}
