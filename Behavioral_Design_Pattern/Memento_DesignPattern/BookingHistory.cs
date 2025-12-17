//3️⃣ Caretaker (History Manager)
class BookingHistory
{
    private Stack<BookingMemento> _history = new();

    public void Save(BookingMemento memento)
    {
        _history.Push(memento);
    }

    public BookingMemento Undo()
    {
        return _history.Pop();
    }
}
