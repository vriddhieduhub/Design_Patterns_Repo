// RealSubject
public class BankAccount : IBankAccount
{
    private double _balance;

    public void Deposit(double amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited ${amount}. Current balance: ${_balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrew ${amount}. Current balance: ${_balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    public double GetBalance() => _balance;
}