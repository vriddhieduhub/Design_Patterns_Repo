namespace Visitor_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<IItem> cart = new()
            {
                new Book(500),
                new Food(200),
                new Book(300)
            };

            var taxVisitor = new TaxVisitor();

            foreach (var item in cart)
            {
                item.Accept(taxVisitor);
            }

            Console.WriteLine($"Total Tax = ₹{taxVisitor.TotalTax}");
            Console.WriteLine("-----END of from Visitor_DesignPattern!------------");
        }
    }
}


/*----------------
Visitor Design Pattern (C#)

Intent:
Represent an operation to be performed on elements of an object structure, without changing the classes of the elements on which it operates.

👉 You add new behavior without modifying existing classes.

When to Use

Object structure is stable

You need to add new operations frequently

You want to avoid changing many existing classes

Real-world examples

Tax calculation on different items

Reporting (PDF, Excel) on domain objects

Compiler syntax tree operations

Shopping cart pricing rules

Core Idea (Very Simple)

Data stays same, operations change
--------------------------------------------
Structure

Visitor → operation interface

ConcreteVisitor → implements operation

Element → accepts visitor

ConcreteElements → actual objects

ObjectStructure → collection of elements
======================================================
⭐ Real-World Example: Shopping Cart (Tax Calculation)
Scenario

Cart has Book and Food

Different tax rules

Later we may add Discount, Shipping, Report
👉 Without changing Book or Food


*/