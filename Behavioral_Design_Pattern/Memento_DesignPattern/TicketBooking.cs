//2️⃣ Originator (Ticket Booking)

class TicketBooking
{
    public string Movie { get; private set; }
    public int SeatCount { get; private set; }
    public decimal TotalAmount { get; private set; }

    public void SelectMovie(string movie)
    {
        Movie = movie;
    }

    public void SelectSeats(int seats)
    {
        SeatCount = seats;
        TotalAmount = seats * 250; // price per seat
    }

    public BookingMemento Save()
    {
        return new BookingMemento(Movie, SeatCount, TotalAmount);
    }

    public void Restore(BookingMemento memento)
    {
        Movie = memento.Movie;
        SeatCount = memento.SeatCount;
        TotalAmount = memento.TotalAmount;
    }

    public void Show()
    {
        Console.WriteLine($"Movie: {Movie}, Seats: {SeatCount}, Total: ₹{TotalAmount}");
    }
}
