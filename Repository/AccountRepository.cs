public class AccountRepository : IAccountRepository
{
    private readonly PetCityContext _context;
    public AccountRepository(PetCityContext context)
    {
        _context = context;
    }

    public AccountRepository()
    {

    }

    public AccountDTO CreateAccount(AccountDTO account)
    {
        try
        {
            Account persistAccount = new Account(account);

            _context.Set<Account>().Add(persistAccount);
            _context.SaveChanges();
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
        var account = (from x in _context.Account
        where x.Id == 3 
        select x).FirstOrDefault();
        return account;
    }
}
