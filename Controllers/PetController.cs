using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetController : ControllerBase
{



 private readonly IPetService _IPetService;
 public PetController(IPetService petService)
    {
        _IPetService = petService;
    }



    [HttpGet]
    public List<Pet> GetAll()
    {
        return _IPetService.GetAll();
    }

    [HttpGet("{id}")]
    public Pet GetPet(int id)
    {
        // var pet = MockData.PetMockDataList.FirstOrDefault(x => x.id == id);
        // return pet;
        return _IPetService.GetPet(id);
    }


    [HttpPost]
    public string PetAdd(Pet pet)
    {
        // MockData.PetMockDataList.Add(pet);
        // return "Ok";


    string eror ="";
       PetValidator validator =new PetValidator();
        ValidationResult results = validator.Validate(pet);
        if (results.IsValid)
        {
            return _IPetService.PetAdd(pet);
        }
        foreach(var Errors in results.Errors)
        {
            eror += Errors.ErrorMessage + "\n";
        }
        return eror;


    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var deletePet = MockData.PetMockDataList.FirstOrDefault(x => x.id == id);
        MockData.PetMockDataList.Remove(deletePet);
        _IPetService.Delete(id);
    }


    [HttpPut("{id}")]
    public Pet Put(Pet pet, int id)
    {

        // PetRepository pet = new PetRepository();
        //  pet.PetEdit(petDTO, id);

        return _IPetService.PetEdit(pet, id);


    }


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

