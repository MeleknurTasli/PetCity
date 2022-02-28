public interface IAccountRepository{
    IEnumerable<Pet> GetAllPets();
     Account GetAccountByEmail();
     Account UpdateAccountByEmail();
     Account UpdateAccountPassword();
      Account ChangeVisibilityOfAccount(); 
     Account BlockAccount();
     Account Role();
}