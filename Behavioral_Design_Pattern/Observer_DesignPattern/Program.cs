namespace Observer_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cmpny = new Stock("ABCCompany");

            var mobile = new MobileApp();
            var email = new EmailService();

            cmpny.Register(mobile);
            cmpny.Register(email);

            cmpny.SetPrice(3500);
            cmpny.SetPrice(3600);
            Console.WriteLine("-----END of from Observer_DesignPattern!------------");
        }
    }
}
/* 
Output
[Mobile] ABCCompany price updated to ₹3500
[Email] ABCCompany price updated to ₹3500
[Mobile] ABCCompany price updated to ₹3600
[Email] ABCCompany price updated to ₹3600
*/

/*-------------

Observer Design Pattern (C#)

Intent:
Define a one-to-many dependency so that when one object (Subject) changes state, all its dependents (Observers) are notified automatically.

When to Use

Many objects must react to state changes

You want loose coupling between notifier and listeners

Event-driven systems

Real-world examples

Stock price alerts

News subscriptions

Email/SMS notifications

UI data binding

.NET events

Structure

Subject → maintains observers

Observer → update interface

ConcreteSubject → actual state

ConcreteObserver → reacts to changes

*/