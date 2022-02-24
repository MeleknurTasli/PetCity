public interface IPetService
{
    ServiceResponse<Pet> GetPet(int id);
    ServiceResponse<List<Pet>> GetAllPet();
    ServiceResponse<string> PetAdd(Pet  pet);
    ServiceResponse<List<Pet>>AddPetList(List<Pet> pets);
    ServiceResponse<Pet> PetEdit(Pet pet,int id);
    ServiceResponse<List<Pet>> GetPetByGenus(string genus);
    
////////////////////////////////Bunlar Yapılacak
    /*
    
    
    ServiceResponse<List<Pet>> GetPetByGenusAndGender(string genus,Gender gender);
    ServiceResponse<List<Pet>> GetPetByFamily(Family family);
    ServiceResponse<List<Pet>> GetPetByUserID(int userID);
    */
    ////////////////////////////////
    

    ServiceResponse<string> PetDelete(int id);
 
}