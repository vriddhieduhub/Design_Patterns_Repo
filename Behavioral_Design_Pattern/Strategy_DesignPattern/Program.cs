namespace Strategy_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var payment = new PaymentContext();

            payment.SetStrategy(new CreditCardPayment());
            payment.Pay(1000);

            payment.SetStrategy(new UpiPayment());
            payment.Pay(500);

            Console.WriteLine("-----END of from Strategy_DesignPattern!------------");
        }
    }
}

/*------------------

Strategy Design Pattern (C#)

Intent:
Define a family of algorithms, encapsulate each one, and make them interchangeable at runtime.
The algorithm can vary independently from the client that uses it.

When to Use

Many if / else or switch statements

Different ways to perform the same task

Algorithm must be chosen at runtime

Real-world examples

Payment methods

Sorting algorithms

Compression (ZIP / RAR)

Discount calculation

===========================================================
⭐ Real-World Example: Payment System
Scenario

User can pay using:

Credit Card

UPI

Cash
*/

