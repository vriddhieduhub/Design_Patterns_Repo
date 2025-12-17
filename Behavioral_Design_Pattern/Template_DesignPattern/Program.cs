namespace Template_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            OrderProcessTemplate online = new OnlineOrder();
            online.ProcessOrder();

            Console.WriteLine();

            OrderProcessTemplate store = new StorePickupOrder();
            store.ProcessOrder();
            Console.WriteLine("-----END of from Template_DesignPattern!------------");
        }
    }
}


/*----------------------

Template Method Design Pattern (C#)

Intent:
Define the skeleton of an algorithm in a base class, and let subclasses override specific steps without changing the algorithm structure.

When to Use

Algorithm steps are fixed, but some steps vary

You want to avoid code duplication

Enforce a standard process

Real-world examples

Online payment flow

Report generation

Build pipelines

Data import workflows

Structure

Abstract Class (Template) → defines algorithm

Template Method → final method calling steps

Primitive Operations → overridden by subclasses

Hook methods → optional overrides
===============================================
⭐ Real-World Example: Online Order Processing
Fixed Steps

Validate order

Take payment

Deliver order

Only payment & delivery vary.
*/

