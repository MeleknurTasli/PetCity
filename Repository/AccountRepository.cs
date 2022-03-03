public class AccountRepository :IAccountRepository
{     
    
    
      

    private readonly PetCityContext _context;
    public AccountRepository(PetCityContext context)
    {
        _context=context;
    }
    public AccountRepository()
    {
            
    }

    public async Task<List<Account>> GetAllAccounts()
    {
        
         var getirilenHESAPLAR= await _context.Account.ToListAsync();        
        return getirilenHESAPLAR;
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

    public async Task<Account> UpdateAccountByEmail(string email, Account account)
    {throw new NotImplementedException();
         
        var updateOperation= _context.Update(account);
         await _context.SaveChangesAsync();
        return account ;                        
    }

    public async Task<Account> UpdateAccountPassword(Account account,string oldpassword, string newpassword)
    {
         var updateOperation= _context.Account.Update(account);
         await _context.SaveChangesAsync();
          return account;                
    }

    public Task<Account> ChangeVisibilityOfAccount()
    {
        throw new NotImplementedException();        
    }

    public Task<Account> BlockAccount()
    {
        throw new NotImplementedException();       
    }

    public Task<Account> Role()
    {
        throw new NotImplementedException();        
    }

    public async Task<AccountDTO> CreateAccount(AccountDTO account)
    {
         try
        {
            Account persistAccount = new Account(account);

             await _context.Set<Account>().AddAsync(persistAccount);    //burayı hocaya soralım 
             await _context.SaveChangesAsync();                                 
            return new AccountDTO(persistAccount);
        }
        catch (Exception e)
        {
            return new AccountDTO(null);    
        }
    }

    

    public Account findAccountById(int id)
    {
        Account accountByID = (from x in _context.Account
                           where x.Id == id
                           select x).FirstOrDefault();
        return accountByID; 
    }

   /* Task<Account> IAccountRepository.FindAccountByEmailAndPassword(LoginDTO loginDTO,Account account)
    {
       Account accountFinded = (from x in _context.Account
                           where x.Email == loginDTO.Email && x.Password == loginDTO.Password
                           select x).FirstOrDefault();
        return account;
    } */

    public Task<Account> FindAccountByEmailAndPassword(LoginDTO loginDTO)
    {
        throw new NotImplementedException();
    }
}

   
