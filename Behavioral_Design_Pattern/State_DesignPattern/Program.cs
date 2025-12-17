namespace State_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----END of from State_DesignPattern!------------");
        }
    }
}

/*------------
State Design Pattern (C#)

Intent:
Allow an object to change its behavior when its internal state changes.
The object will appear to change its class.

When to Use

Behavior depends on current state

Many if / else or switch statements

State transitions are complex

Real-world examples

Order lifecycle (New → Paid → Shipped → Delivered)

ATM machine

Traffic lights

Media player

Structure

State → interface

ConcreteStates → different behaviors
==========================

⭐ Real-World Example: Online Order Status
States

New

Paid

Shipped

Delivered
*/

