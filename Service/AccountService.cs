public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository=accountRepository;
    }

    public async Task<Account> BlockAccount()
    {
        throw new NotImplementedException();        //yarın yapıcaz, önce bi yürütelim
    }

    public async Task<Account> ChangeVisibilityOfAccount()
    {
        throw new NotImplementedException();            //yarın yapıcaz, önce bi yürütelim
    }

    public async Task<Account> CreateNewAccount(Account account)
    {
        await _accountRepository.CreateAccount(account);        //repodaki methodun adını yazıyoruz, repoda da bir alt katman olan db(contexti işliyoruz vs...)
        
        return account;
    }

    public async Task<Account> GetAccountByEmail(string email)
    {
        var getAccountByEmail=await _accountRepository.GetAccountByEmail(email);
        return getAccountByEmail;
    }

    public async Task<List<Account>> GetAllAccounts()
    {
        return await _accountRepository.GetAllAccounts();   //repoda tolist dediğimiz için bu katmana direkt tolist hali geldi,burdan da controllera gönderiyoz
        }

    public async Task<Account> Role()
    {
        throw new NotImplementedException();        //yarın yapıcaz, önce bi yürütelim
    }

    public async Task<Account> UpdateAccountByEmail(Account account, string email)
    {
        throw new NotImplementedException();                //yarın yapıcaz, önce bi yürütelim
    }

    public async Task<Account> UpdateAccountPassword(string oldpassword, string newpassword)
    {
        throw new NotImplementedException();            //yarın yapıcaz, önce bi yürütelim
    }
}

    

