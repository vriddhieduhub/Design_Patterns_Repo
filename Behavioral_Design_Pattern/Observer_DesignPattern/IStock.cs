interface IStock
{
    void Register(IInvestor investor);
    void Unregister(IInvestor investor);
    void Notify();
}