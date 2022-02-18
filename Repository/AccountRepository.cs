public class AccountRepository
{
    public List<Account> getAccount()
    {
        return MockData.AccountMockDataList;
    }
  
    public Account getAccountByEmail(string email)
    {
        var user = MockData.AccountMockDataList.FirstOrDefault(h => h.Email == email);
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
            MockData.AccountMockDataList.Add(account);
        }else{
            return "Kullanıcı Emaili Kayıtlıdır.!!!";
        }
        
        return "Ok";
    }
}