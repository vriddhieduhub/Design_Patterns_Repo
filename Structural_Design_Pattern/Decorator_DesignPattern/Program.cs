using System;
using System.Threading.Tasks;

namespace Decorator_DesignPattern
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            INotifier notifier = new BasicNotifier();

            // Add Email feature
            notifier = new EmailNotifier(notifier);

            // Add SMS feature
            notifier = new SMSNotifier(notifier);

            notifier.Send("Your order has been shipped!");

            Console.WriteLine("----End of from Decorator_DesignPattern!----------");
        }
    }
}

/* ------------
What is the Decorator Pattern?

The Decorator Pattern allows you to dynamically add behavior to an object without modifying its class. It's useful when you want to add responsibilities to objects at runtime rather than compile-time.

Structure :

Component – Interface or abstract class defining the core behavior.
ConcreteComponent – The original object to be decorated.
Decorator – Base decorator class that implements the Component interface and has a reference to a Component.
ConcreteDecorator – Extends Decorator to add extra behavior.

*/