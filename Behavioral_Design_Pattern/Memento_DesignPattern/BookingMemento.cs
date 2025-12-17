//1️⃣ Memento (Booking Snapshot)
class BookingMemento
{
    public string Movie { get; }
    public int SeatCount { get; }
    public decimal TotalAmount { get; }

    public BookingMemento(string movie, int seatCount, decimal totalAmount)
    {
        Movie = movie;
        SeatCount = seatCount;
        TotalAmount = totalAmount;
    }
}