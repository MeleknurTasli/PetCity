using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetHelperController : ControllerBase
{


    [HttpGet]
    public List<PetHelper> Get()
    {
        return MockData.PetHelperMockDataList;
    }
    [HttpPost]
    public string Add(PetHelper petHelper)
    {
        MockData.PetHelperMockDataList.Add(petHelper);
        return "Ok";
    }
    //[HttpGet("{latitude}/{longtitude}")]
    // public PetHelper FindPetHelperByLatLong(string latitude,string longtitude){
    //     var result = PetHelperRepository.FindPetHelperByLatLong(latitude,longtitude);
    //     return result;
    // }
}
