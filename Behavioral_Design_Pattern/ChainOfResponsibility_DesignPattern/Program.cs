namespace ChainOfResponsibility_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ExpenseApprover manager = new Manager();
            ExpenseApprover director = new Director();
            ExpenseApprover ceo = new CEO();

            manager.SetNext(director);
            director.SetNext(ceo);

            manager.Approve(5000);
            manager.Approve(20000);
            manager.Approve(100000);
            Console.WriteLine("-----END of from ChainOfResponsibility_DesignPattern!------------");
        }
    }
}

/*-----------
1. What is Chain of Responsibility?

The Chain of Responsibility pattern lets you pass a request along a chain of handlers.
Each handler decides either to handle the request or pass it to the next handler.

👉 The sender does not know which handler will process the request.

2. When to Use

Multiple objects can handle a request

You want to avoid tight coupling between sender and receiver

Examples:

Approval workflows (leave, expense, loan)

Logging (Info → Warning → Error)

Request validation pipelines

Middleware (ASP.NET Core)

3. Structure
Client → Handler1 → Handler2 → Handler3


Each handler:

Has a reference to the next handler

Either handles or forwards the request

=================================================


Practical Example: Expense Approval System
Scenario

Manager can approve up to ₹10,000

Director up to ₹50,000

CEO above ₹50,000
*/

