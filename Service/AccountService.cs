public class AccountService : IAccountService
{
    private readonly AccountRepository _accountRepository;
    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository=accountRepository;
    }
    Account IAccountService.BlockAccount()
    {
        throw new NotImplementedException();
    }

    public List<Account> GetAllAccounts()
    {
        return ((IAccountService)Account).GetAllAccounts();
    }

    public Account GetAccountByEmail(string email)
    {
        return ((IAccountService)Account).GetAccountByEmail(email);
    }

    public async Task<Account> CreateNewAccount(Account account)
    {
        
        return await _accountRepository.CreateNewAccount(account);
    }

    public Account ChangeVisibilityOfAccount()
    {
        return ((IAccountService)Account).ChangeVisibilityOfAccount();
    }

    public Account UpdateAccountByEmail(Account account, string email)
    {
        return ((IAccountService)Account).UpdateAccountByEmail(account, email);
    }

    public Account UpdateAccountPassword(string oldpassword, string newpassword)
    {
        return ((IAccountService)Account).UpdateAccountPassword(oldpassword, newpassword);
    }

    public Account BlockAccount()
    {
        return ((IAccountService)Account).BlockAccount();
    }

    public Account Role()
    {
        return ((IAccountService)Account).Role();
    }
}

    

