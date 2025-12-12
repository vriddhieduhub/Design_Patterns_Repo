using System;
using System.Threading.Tasks;

namespace Proxy_DesignPattern
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            IBankAccount account = new BankAccountProxy("mypassword");

        account.Deposit(1000);
        account.Withdraw(200); // asks for password
        account.Withdraw(100); // asks for password
        Console.WriteLine($"Final Balance: ${account.GetBalance()}");

            Console.WriteLine("---------End of Proxy_DesignPattern!---------");
        }
    }
}

/* ---------------
1. What is the Proxy Pattern?

The Proxy Pattern is a structural design pattern that provides a surrogate or placeholder for another object to control access to it.

It can add a layer between a client and an object.

Common uses:

Lazy initialization (virtual proxy)
Access control (protection proxy)
Remote access (remote proxy)
Logging or caching

2. Structure
Client --> ISubject --> RealSubject
                 \
                  --> Proxy (controls access to RealSubject)


Subject (interface): Defines common operations.
RealSubject: The real object that does the work.
Proxy: Controls access to RealSubject, may add extra behavior.
Client: Interacts with Proxy instead of RealSubject.
*/