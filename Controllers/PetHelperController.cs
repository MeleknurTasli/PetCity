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
    [HttpGet("{latitude}/{longtitude}")]
    public PetHelperDTO FindPetHelperByLatLong(string latitude,string longtitude){
        var result = PetHelperRepository.FindPetHelperByLatLong(latitude,longtitude);
        return result;
    }
}
