using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    [HttpPost]

    public string SetAccount(AccountDTO account)
    {
        AccountDTO.AccountDTOList.Add(account);
        return "Ok";
    }

    [HttpGet]
    public List<AccountDTO> getAccount()
    {
        return AccountDTO.AccountDTOList;
    }

    [HttpGet("{email}")]
    public AccountDTO getAccountByEmail(string email)
    {
        var user = AccountDTO.AccountDTOList.FirstOrDefault(h => h.Email == email);
        if (user != null)
        {
            return user;
        }
        return null;
    }
}