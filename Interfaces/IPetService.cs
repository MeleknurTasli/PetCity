public interface IPetService
{
    List<Pet> GetPets();
    Pet getPetsByUserId(int id);
    string PetAdd(Pet  pet);
}