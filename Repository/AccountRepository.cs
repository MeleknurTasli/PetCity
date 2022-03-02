public class AccountRepository : IAccountRepository
{     
    
    
      

    private readonly PetCityContext _context;
    public AccountRepository(PetCityContext context)
    {
        _context=context;
    }
    public AccountRepository()
    {
            //Constructor methodun boşu
    }

    public async Task<List<Account>> GetAllAccounts()
    {
        
         var getirilenHESAPLAR= await _context.Account.ToListAsync();        
        return getirilenHESAPLAR;
    }

    public Account CreateAccount(Account account)
    {
         _context.Account.AddAsync(account);       
         _context.SaveChangesAsync();
        return account;
    }

    public async Task<Account> GetAccountByEmail(string email)
    {
        return await _context.Account.FirstOrDefaultAsync(a=>a.Email==email); 
    }

    public Task<Account> UpdateAccountByEmail(string email, Account account)
    {
        throw new NotImplementedException();        //hALLEDİCEZ, MERGELERİ VS BİTİRDİKTEN SONRA...
    }

    public Task<Account> UpdateAccountPassword(string oldpassword, string newpassword)
    {
        throw new NotImplementedException();    //hALLEDİCEZ, MERGELERİ VS BİTİRDİKTEN SONRA...
    }

    public Task<Account> ChangeVisibilityOfAccount()
    {
        throw new NotImplementedException();        //hALLEDİCEZ, MERGELERİ VS BİTİRDİKTEN SONRA...
    }

    public Task<Account> BlockAccount()
    {
        throw new NotImplementedException();        //hALLEDİCEZ, MERGELERİ VS BİTİRDİKTEN SONRA...
    }

    public Task<Account> Role()
    {
        throw new NotImplementedException();        //hALLEDİCEZ, MERGELERİ VS BİTİRDİKTEN SONRA...
    }

    public async Task<AccountDTO> CreateAccount(AccountDTO account)
    {
         try
        {
            Account persistAccount = new Account(account);

             await _context.Set<Account>().AddAsync(persistAccount);    //burayı hocaya soralım bida
             await _context.SaveChangesAsync();                                 
            return new AccountDTO(persistAccount);
        }
        catch (Exception e)
        {
            return new AccountDTO(null);    
        }
    }

    public Account FindAccountByEmailAndPassword(LoginDTO loginDTO)
    {
        Account account = (from x in _context.Account
                           where x.Email == loginDTO.Email && x.Password == loginDTO.Password
                           select x).FirstOrDefault();
        return account;
    }

    public Account findAccountById(int id)
    {
        Account accountByID = (from x in _context.Account
                           where x.Id == id
                           select x).FirstOrDefault();
        return accountByID; 
    }
}

   
