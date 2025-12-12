using System;
using System.Threading.Tasks;

namespace Facade_DesignPattern
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            BankFacade bank = new BankFacade();

            // Client uses simple methods instead of interacting with multiple services
            bank.CheckBalance(101);
            bank.TransferMoney(101, 102, 500);
            bank.ApplyLoan(101, 2000);
            Console.WriteLine("-----------End of Facade_DesignPattern!----------");
        }
    }
}

/* ------------
1. What is the Facade Pattern?

The Facade Pattern provides a simplified interface to a complex subsystem.
It hides the complexities of the system from the client.
The client interacts with the facade, not the individual components.
This reduces coupling and makes the system easier to use.

When to use:
When a system has many interdependent classes.
When you want to provide a simple interface to a complex subsystem.
When you want to decouple client code from subsystem classes.


*/