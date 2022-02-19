using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetController : ControllerBase
{


    [HttpGet]
    public List<Pet> Get()
    {
        return MockData.PetMockDataList;
    }

    [HttpGet("{id}")]
    public Pet GetUser(int id)
    {
        var pet = MockData.PetMockDataList.FirstOrDefault(x => x.id == id);
        return pet;
    }


    [HttpPost]
    public string Add(Pet pet)
    {
        MockData.PetMockDataList.Add(pet);
        return "Ok";
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var deletePet = MockData.PetMockDataList.FirstOrDefault(x => x.id == id);
        MockData.PetMockDataList.Remove(deletePet);
    }


    [HttpPut("{id}")]
    public void Put(Pet petDTO, int id)
    {
        PetRepository pet = new PetRepository();
        pet.PetEdit(petDTO, id);
        //var editedPet = PetDTO.PetList.FirstOrDefault(x=>x.id ==id);
        // editedPet.name = petDTO.name;
        // editedPet.About = petDTO.About;
        // editedPet.BirthDate = petDTO.BirthDate;
        // editedPet.Family = petDTO.Family;
        // editedPet.Gender = petDTO.Gender;
        // editedPet.Genus = petDTO.Genus;
        // editedPet.UserID = petDTO.UserID;

        //return editedPet ;

    }
}
