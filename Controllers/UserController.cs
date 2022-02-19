using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]

    public string SetUser(User user)
    {
        MockData.UserMockDataList.Add(user);
        return "Ok";
    }

    [HttpGet]
    public List<User> GetUser()
    {
        return MockData.UserMockDataList;
    }

}