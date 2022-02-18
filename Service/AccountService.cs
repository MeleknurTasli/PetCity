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
        AccountDTO.AccountDTOList.Add(account);
        return "Ok";
    }


}