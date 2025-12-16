abstract class ExpenseApprover
{
    protected ExpenseApprover _next;

    public void SetNext(ExpenseApprover next)
    {
        _next = next;
    }

    public abstract void Approve(decimal amount);
}
