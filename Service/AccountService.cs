public class AccountService { 

    private AccountRepository accountRepository = new AccountRepository();
    public List<AccountDTO> getAccount()
    {
        return accountRepository.getAccount();
    }

   public AccountDTO getAccountByEmail(string email)
    {
        var user = accountRepository.getAccountByEmail(email);
        if (user != null)
        {
            return user;
        }
        return null;
    }

    public string setAccount(AccountDTO account)
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