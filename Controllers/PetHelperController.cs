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
}
