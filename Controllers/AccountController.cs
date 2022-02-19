using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    [HttpPost]
    public string SetAccount(Account account)
    {
        MockData.AccountMockDataList.Add(account);
        return "Ok";
    }

    [HttpGet]
    public List<Account> getAccount()
    {
        return MockData.AccountMockDataList;
    }

    [HttpGet("{email}")]
    public Account getAccountByEmail(string email)
    {
        var user = MockData.AccountMockDataList.FirstOrDefault(h => h.Email == email);
        if (user != null)
        {
            return user;
        }
        return null;
    }
}