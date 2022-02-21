public interface IPetService
{
    ServiceResponse<List<Pet>> GetAll();
    ServiceResponse<Pet> GetPet(int id);
    ServiceResponse<string> PetAdd(Pet  pet);
    ServiceResponse<string> Delete(int id);
    ServiceResponse<Pet> PetEdit(Pet pet,int id);


}