namespace Iterator_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var tvChannels = new ChannelCollection();
            tvChannels.AddChannel("BBC");
            tvChannels.AddChannel("CNN");
            tvChannels.AddChannel("Discovery");

            var iterator = tvChannels.CreateIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
            Console.WriteLine("-----END of from Mediator_DesignPattern!------------");
        }
    }
}
/* ---------------
Iterator Design Pattern (C#)

Intent:
Provide a way to access elements of a collection sequentially without exposing its internal structure.

When to Use

You want to traverse a collection without knowing how it’s stored

You want multiple traversal strategies

You want a common interface for different collections

Real-world examples

TV remote → channel list

Playlist → songs

Menu → food items

.NET IEnumerator / IEnumerable
================================================
Structure

Iterator → traversal interface

ConcreteIterator → implements traversal

Aggregate → collection interface

ConcreteAggregate → actual collection


*/

