using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]

    public string SetUser(UserDTO user)
    {
        UserDTO.UserDTOList.Add(user);
        return "Ok";
    }

    [HttpGet]
    public List<UserDTO> GetUser()
    {
        return UserDTO.UserDTOList;
    }

}