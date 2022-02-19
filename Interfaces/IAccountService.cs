public interface IAccountService
{
    List<Account> getAccount();
    Account getAccountByEmail(string email);
    string setAccount(Account account);
}