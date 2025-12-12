// Facade
public class BankFacade
{
    private AccountService _accountService;
    private TransferService _transferService;
    private LoanService _loanService;

    public BankFacade()
    {
        _accountService = new AccountService();
        _transferService = new TransferService();
        _loanService = new LoanService();
    }

    public void CheckBalance(int accountId)
    {
        _accountService.CheckBalance(accountId);
    }

    public void TransferMoney(int fromAccount, int toAccount, double amount)
    {
        _transferService.TransferMoney(fromAccount, toAccount, amount);
    }

    public void ApplyLoan(int accountId, double amount)
    {
        _loanService.ApplyLoan(accountId, amount);
    }
}