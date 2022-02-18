using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetHelperController : ControllerBase
{

    
    [HttpGet]
    public List<PetHelperDTO> Get()
    {
        return PetHelperDTO.petHelperStatic;        
    }
    [HttpPost]
    public string Add(PetHelperDTO petHelper){
        PetHelperDTO.petHelperStatic.Add(petHelper);
        return "Ok";
    }
}
