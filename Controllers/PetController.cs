using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetController : ControllerBase
{    


    [HttpGet]
    public List<PetDTO> Get()
    {
        return PetDTO.PetList;        
    }

 [HttpGet("{id}")]
    public PetDTO GetUser(int id)
    {
        var pet = PetDTO.PetList.FirstOrDefault(x=>x.id == id);
        return pet;       
    }


    [HttpPost]
    public string Add(PetDTO pet){
        PetDTO.PetList.Add(pet);
        return "Ok";
    }

    [HttpDelete ("{id}")]
    public void Delete(int id)
    {
        var deletePet = PetDTO.PetList.FirstOrDefault(x=>x.id ==id);
        PetDTO.PetList.Remove(deletePet);
    }


    [HttpPut("{id}")]
    public void Put(PetDTO petDTO,int id)
    {
        PetRepository pet =new PetRepository(); 
        pet.PetEdit(petDTO,id);    
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
