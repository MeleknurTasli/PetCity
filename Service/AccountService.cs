public class AccountService : IAccountService{ 

    private AccountRepository accountRepository;

    public AccountService()
    {
        accountRepository = new AccountRepository();
    }
    
    public List<Account> getAccount()
    {
        return accountRepository.getAccount();
    }

   public Account getAccountByEmail(string email)
    {
        var user = accountRepository.getAccountByEmail(email);
        if (user != null)
        {
            return user;
        }
        return null;
    }

    public string setAccount(Account account)
    {
       if(getAccountByEmail(account.Email) == null)
        {
            accountRepository.setAccount(account);
        }else{
            return "Kullanıcı Emaili Kayıtlıdır.!!!";
        }
        
        return "Ok";
    }
}