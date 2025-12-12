// Flyweight
public interface IMarker
{
    void Display(int x, int y); // Extrinsic state: position
}

// ConcreteFlyweight
public class Marker : IMarker
{
    private string _icon;   // Intrinsic state (shared)

    public Marker(string icon)
    {
        _icon = icon;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Displaying marker '{_icon}' at ({x},{y})");
    }
}