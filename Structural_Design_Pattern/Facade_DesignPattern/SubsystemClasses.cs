// Subsystems
public class AccountService
{
    public void CheckBalance(int accountId)
    {
        Console.WriteLine($"Checking balance for account {accountId}: $10,000");
    }
}

public class TransferService
{
    public void TransferMoney(int fromAccount, int toAccount, double amount)
    {
        Console.WriteLine($"Transferring ${amount} from account {fromAccount} to account {toAccount}");
    }
}

public class LoanService
{
    public void ApplyLoan(int accountId, double amount)
    {
        Console.WriteLine($"Loan of ${amount} applied for account {accountId}");
    }
}
