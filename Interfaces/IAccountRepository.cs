public interface IAccountRepository
{
    AccountDTO CreateAccount(AccountDTO account);
    Account FindAccountByEmailAndPassword(LoginDTO loginDTO);
    Account findAccountById(int id);

}