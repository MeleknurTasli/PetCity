public interface IPetService
{
    ServiceResponse<List<Pet>> GetAllPet();
    ServiceResponse<List<Pet>>AddPetList(List<Pet> pets);
    ServiceResponse<Pet> GetPet(int id);
    ServiceResponse<string> PetAdd(Pet  pet);
    ServiceResponse<string> PetDelete(int id);
    ServiceResponse<Pet> PetEdit(Pet pet,int id);


}