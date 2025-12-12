// 📂 3. Composite — Menu (can contain items + other menus)
public class Menu : IMenuComponent
{
    public string Title { get; }
    private readonly List<IMenuComponent> _items = new();

    public Menu(string title)
    {
        Title = title;
    }

    public void Add(IMenuComponent component)
    {
        _items.Add(component);
    }

    public void Remove(IMenuComponent component)
    {
        _items.Remove(component);
    }

    public void Display(int indent = 0)
    {
        Console.WriteLine(new string(' ', indent) + $"+ {Title}");

        foreach (var item in _items)
        {
            item.Display(indent + 4);
        }
    }
}
