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
}