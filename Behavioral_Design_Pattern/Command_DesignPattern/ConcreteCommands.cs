class PastaOrder : IOrderCommand
{
    private readonly Chef _chef;
    public PastaOrder(Chef chef) => _chef = chef;

    public void Execute() => _chef.CookPasta();
}

class PizzaOrder : IOrderCommand
{
    private readonly Chef _chef;
    public PizzaOrder(Chef chef) => _chef = chef;

    public void Execute() => _chef.CookPizza();
}
