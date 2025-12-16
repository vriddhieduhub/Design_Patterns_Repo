namespace Command_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Receiver
            Chef chef = new Chef();

            // Commands
            IOrderCommand pasta = new PastaOrder(chef);
            IOrderCommand pizza = new PizzaOrder(chef);

            // Invoker
            Waiter waiter = new Waiter();

            // Client actions
            waiter.TakeOrder(pasta);
            waiter.TakeOrder(pizza);

            // Execute all commands
            waiter.PlaceOrders();
            Console.WriteLine("-----END of from Command_DesignPattern!------------");
        }
    }
}
/* --------------
Command Design Pattern (C#)

Intent:
Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undo/redo operations.

When to Use

-You want to decouple sender and receiver
-You need undo / redo
-You want to store or queue operations
-You want to support macro commands

Real-world examples ::::::

Remote controls

Menu buttons

Transaction systems
-----------------------
Structure

Command → interface
ConcreteCommand → binds receiver + action
Receiver → does the actual work
Invoker → triggers the command
Client → creates & configures commands
=========================================================

1️⃣ Restaurant Order System 🍽️ (Very Real)
Scenario

Waiter takes orders

Chef prepares food

Orders can be queued, cancelled, or re-ordered
*/

