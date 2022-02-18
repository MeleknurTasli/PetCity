public class AccountService { 

    public List<AccountDTO> getAccount()
    {
        return AccountDTO.AccountDTOList;
    }

   public AccountDTO getAccountByEmail(string email)
    {
        var user = AccountDTO.AccountDTOList.FirstOrDefault(h => h.Email == email);
        if (user != null)
        {
            return user;
        }
        return null;
    }

    public string SetAccount(AccountDTO account)
    {
       if(getAccountByEmail(account.Email) == null)
        {
            AccountDTO.AccountDTOList.Add(account);
        }else{
            return "Kullanıcı Emaili Kayıtlıdır.!!!";
        }
        
        return "Ok";
    }


}