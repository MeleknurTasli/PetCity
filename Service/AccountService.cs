public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository= accountRepository; //BU constructor'ın BOŞUNU OLUŞTURMADAN DÜN ÇALIŞTIRDIK VE SORUNSUZ ÇALIŞMIŞTI AMA REPODAYKEN HOCA BOŞ CONSTRUCTOR OLUŞTURDU,NEDEN ?
    }

    public Task<Account> BlockAccount()
    {
        throw new NotImplementedException();        //HALLEDİCEZ
    }

    public Task<Account> ChangeVisibilityOfAccount()
    {
        throw new NotImplementedException();        //HALLEDİCEZ
    }

     public async Task<Account> CreateNewAccount(Account account)
    {
         return  await _accountRepository.CreateAccount(account);       
        
        
    }

    public async Task<Account> GetAccountByEmail(string email)
    {
       return  await _accountRepository.GetAccountByEmail(email);
        
    }

    public async Task<List<Account>> GetAllAccounts()
    {
        return await _accountRepository.GetAllAccounts();
    }

    public Task<Account> Role()
    {
        throw new NotImplementedException();        //halledicez
    }

    public  async Task<Account> UpdateAccountByEmail(Account account, string email)
    {
        return await _accountRepository.UpdateAccountByEmail(email,account);
    }

    public async Task<Account> UpdateAccountPassword(string oldpassword, string newpassword)
    {
        return await _accountRepository.UpdateAccountPassword(oldpassword,newpassword);
    }
}

    

