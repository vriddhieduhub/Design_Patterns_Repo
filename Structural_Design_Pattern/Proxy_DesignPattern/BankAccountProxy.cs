// Proxy
public class BankAccountProxy : IBankAccount
{
    private BankAccount _realAccount;
    private string _password; // simple access control

    public BankAccountProxy(string password)
    {
        _password = password;
        _realAccount = new BankAccount();
    }

    private bool Authenticate(string password)
    {
        return _password == password;
    }

    public void Deposit(double amount)
    {
        _realAccount.Deposit(amount);
    }

    public void Withdraw(double amount)
    {
        Console.Write("Enter password to withdraw: ");
        string? input = Console.ReadLine();
        if (Authenticate(input!))
        {
            _realAccount.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Access denied! Wrong password.");
        }
    }

    public double GetBalance()
    {
        return _realAccount.GetBalance();
    }
}