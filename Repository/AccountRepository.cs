public class AccountRepository : IAccountRepository
{     
    
    
      //ACcountDTO yüzünden mi bu hatalar ??????


    private readonly PetCityContext _context;
    public AccountRepository(PetCityContext context)
    {
        _context=context;
    }

    public async Task<Account> BlockAccount()
    {
        throw new NotImplementedException();        //yarın halledicez, önce bi yürütelim
    }

    public async Task<Account> ChangeVisibilityOfAccount()
    {
        throw new NotImplementedException();            //yarın halledicez, önce bi yürütelim
    }

    public async Task<Account> CreateAccount(Account account)
    {
        await _context.Account.AddAsync(account);
        await _context.SaveChangesAsync();
        return account;
    }

    public async Task<Account> GetAccountByEmail(string email)
    {
         return await _context.Account.FirstOrDefaultAsync(a=>a.Email==email);
    }

    public async Task<List<Account>> GetAllAccounts()
    {
        return await _context.Set<Account>().ToListAsync();
    }

    public async Task<Account> Role()
    {
        throw new NotImplementedException();            //yarın halledicez, önce bi yürütelim
    }

    public async Task<Account> UpdateAccountByEmail(string email, Account account)
    {
        throw new NotImplementedException();                //yarın halledicez, önce bi yürütelim
    }

    public async Task<Account> UpdateAccountPassword(string oldpassword, string newpassword)
    {
        throw new NotImplementedException();            //yarın halledicez, önce bi yürütelim
    }
}

   
