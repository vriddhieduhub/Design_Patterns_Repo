namespace Mediator_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var chatRoom = new ChatRoom();

            var john = new ChatUser(chatRoom, "John");
            var alice = new ChatUser(chatRoom, "Alice");
            var bob = new ChatUser(chatRoom, "Bob");

            chatRoom.Register(john);
            chatRoom.Register(alice);
            chatRoom.Register(bob);

            john.Send("Hello everyone!");
            alice.Send("Hi John!");
            Console.WriteLine("-----END of from Mediator_DesignPattern!------------");
        }
    }
}

/*------------
Mediator Design Pattern (C#)

Intent:
Define an object that encapsulates how a set of objects interact, promoting loose coupling by preventing objects from referring to each other explicitly.

When to Use

Many objects communicate in complex ways

You want to avoid many-to-many dependencies

Centralize communication logic

Real-world examples :::::::::::::::

Air traffic control

Chat room

UI form controls

Microservice orchestrators

============================================
Structure

Mediator → interface

ConcreteMediator → coordination logic

Colleague → communicates via mediator

ConcreteColleagues → actual components

==========================================================
⭐ Real-World Example: Chat Room (Very Common)
Scenario

Users send messages but never talk directly to each other.
*/

/*----------------------
Mediator                 vs            Observer (Very Important)
 
Central coordinator	                  Publish/Subscribe
Controls interaction	              Notifies changes
Reduces many-to-many	              One-to-many
Complex workflows	                  State updates



How to Recognize Mediator Pattern

If you see:

Objects never call each other directly

One central coordinator

Complex interaction rules

👉 It’s Mediator Pattern.
*/