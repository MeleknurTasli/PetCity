public class AccountRepository : IAccountRepository
{
    private readonly PetCityContext _context;
    public AccountRepository(PetCityContext context)
    {
        _context=context;
    }
    Account IAccountRepository.BlockAccount()
    {
        throw new NotImplementedException();
    }

    Account IAccountRepository.ChangeVisibilityOfAccount()
    {
        throw new NotImplementedException();
    }

    Account IAccountRepository.GetAccountByEmail()
    {
        throw new NotImplementedException();
    }

    IEnumerable<Pet> IAccountRepository.GetAllAccounts()
    {
        return await _context.Set<Account>().ToListAsync();
    }

    Account IAccountRepository.Role()
    {
        throw new NotImplementedException();
    }

    Account IAccountRepository.UpdateAccountByEmail(string email,Account account)
    {
        var Final = _context.Update(email);
            await _context.SaveChangesAsync();
            return Final;
    }

    Account IAccountRepository.UpdateAccountPassword()
    {
        throw new NotImplementedException();
    }
}
