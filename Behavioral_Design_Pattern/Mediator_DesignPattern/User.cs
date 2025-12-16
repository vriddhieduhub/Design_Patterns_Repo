abstract class User
{
    protected IChatMediator _mediator;
    protected string _name;

    protected User(IChatMediator mediator, string name)
    {
        _mediator = mediator;
        _name = name;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}
