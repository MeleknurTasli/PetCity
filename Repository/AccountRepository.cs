public class AccountRepository : IAccountRepository
{
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

    IEnumerable<Pet> IAccountRepository.GetAllPets()
    {
        throw new NotImplementedException();
    }

    Account IAccountRepository.Role()
    {
        throw new NotImplementedException();
    }

    Account IAccountRepository.UpdateAccountByEmail()
    {
        throw new NotImplementedException();
    }

    Account IAccountRepository.UpdateAccountPassword()
    {
        throw new NotImplementedException();
    }
}
