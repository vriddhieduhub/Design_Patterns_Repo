namespace Memento_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var booking = new TicketBooking();
            var history = new BookingHistory();

            booking.SelectMovie("Interstellar");
            history.Save(booking.Save()); // State 1

            history.Save(booking.Save()); // Save BEFORE change
            booking.SelectSeats(2);       // Change
            booking.Show();

            Console.WriteLine("User clicks BACK");

            booking.Restore(history.Undo()); // Restore previous
            booking.Show();
            Console.WriteLine("-----END of from Memento_DesignPattern!------------");
        }
    }
}
/*
✅ Output Now
Movie: Interstellar, Seats: 2, Total: ₹500
User clicks BACK
Movie: Interstellar, Seats: 0, Total: ₹0


✔ Undo works
✔ State changed
✔ Pattern demonstrated correctly

*/

/* ----------------
Memento Design Pattern (C#)

Intent:
Capture and externalize an object’s internal state so that it can be restored later, without violating encapsulation.

When to Use

You need Undo / Redo
You want to take snapshots of state
You must not expose internal structure
Real-world examples
Text editor undo
Game save / load
Form rollback

Database transaction rollback (conceptually)

====================================================
Structure

Originator → object whose state changes

Memento → snapshot of state

Caretaker → stores and restores mementos

==================================================
Memento vs Snapshot (Interview Tip)

Snapshot becomes Memento when encapsulation is preserved.


==================================================


🎬 Memento Pattern – Cinema Ticket Booking (C#)
Scenario

User is booking a movie ticket:

Select movie

Select seats

Select snacks

Apply coupon
❌ User clicks Back / Cancel → restore previous state

👉 Booking state is saved as Memento

Roles Mapping
Pattern Role	Cinema Booking
Originator	TicketBooking
Memento	BookingMemento
Caretaker	BookingHistory
Client	UI / Controller
*/
