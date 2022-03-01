public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository= accountRepository;
    }

    public Account BlockAccount()
    {
        throw new NotImplementedException();
    }

    public Account ChangeVisibilityOfAccount()
    {
        throw new NotImplementedException();
    }

    public AccountDTO CreateNewAccount(AccountDTO account)
    {
        return _accountRepository.CreateAccount(account);
    }

    public Account GetAccountByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public List<Account> GetAllAccounts()
    {
        throw new NotImplementedException();
    }

    public Account Role()
    {
        throw new NotImplementedException();
    }

    public Account UpdateAccountByEmail(Account account, string email)
    {
        throw new NotImplementedException();
    }

    public Account UpdateAccountPassword(string oldpassword, string newpassword)
    {
        throw new NotImplementedException();
    }
}

    

