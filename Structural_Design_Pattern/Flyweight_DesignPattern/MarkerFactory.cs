// Flyweight Factory
public class MarkerFactory
{
    private Dictionary<string, IMarker> _markers = new Dictionary<string, IMarker>();

    public IMarker GetMarker(string icon)
    {
        if (!_markers.ContainsKey(icon))
        {
            _markers[icon] = new Marker(icon);
        }
        return _markers[icon];
    }
}