public interface IAccountRepository{
    IEnumerable<Pet> GetAllAccounts();
     Account GetAccountByEmail();
     Account UpdateAccountByEmail();
     Account UpdateAccountPassword();
      Account ChangeVisibilityOfAccount(); 
     Account BlockAccount();
     Account Role();
}