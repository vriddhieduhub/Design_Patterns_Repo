using System;
using System.Threading.Tasks;

namespace Flyweight_DesignPattern
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            MarkerFactory factory = new MarkerFactory();
            List<(IMarker, int, int)> mapMarkers = new List<(IMarker, int, int)>();

            // Add markers
            mapMarkers.Add((factory.GetMarker("Restaurant"), 10, 20));
            mapMarkers.Add((factory.GetMarker("Restaurant"), 30, 50));
            mapMarkers.Add((factory.GetMarker("Hotel"), 15, 25));
            mapMarkers.Add((factory.GetMarker("Cafe"), 40, 60));
            mapMarkers.Add((factory.GetMarker("Restaurant"), 50, 70)); // Reused icon

            // Display markers
            foreach (var (marker, x, y) in mapMarkers)
            {
                marker.Display(x, y);
            }

            Console.WriteLine("Starting application... from Flyweight_DesignPattern!");
        }
    }
}

/* -------------------
1. What is the Flyweight Pattern?

The Flyweight Pattern is a structural design pattern that reduces memory usage by sharing as much data as possible with similar objects.
Useful when you have a large number of similar objects that consume a lot of memory.
Separates intrinsic state (shared) from extrinsic state (unique per object).

Use cases:
Text editors (characters share font/formatting data)
Particle systems in games
Tree/graph rendering
Document management



2. Structure
Flyweight (interface)
   |
ConcreteFlyweight (shared state)
   |
FlyweightFactory (creates/shares flyweights)
Client (uses flyweights with extrinsic state)


Intrinsic state: Shared, stored in Flyweight (e.g., font type).
Extrinsic state: Unique per object, passed by the client (e.g., position).




################################

Imagine an app that displays thousands of points of interest (POIs) on a map.
 Many markers have the same icon, but different positions.
  Using Flyweight, we can share the icon instead of storing it separately for each marker.

*/