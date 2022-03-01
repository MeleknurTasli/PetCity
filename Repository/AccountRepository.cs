public class AccountRepository : IAccountRepository
{
    private readonly PetCityContext _context;
    public AccountRepository(PetCityContext context)
    {
        _context = context;
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
}
