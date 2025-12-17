interface IOrderState
{
    void Next(OrderContext context);
    void Cancel(OrderContext context);
}
