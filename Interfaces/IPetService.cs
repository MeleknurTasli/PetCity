public interface IPetService
{
    List<Pet> GetAll();
    Pet GetPet(int id);
    string PetAdd(Pet  pet);
    string Delete(int id);

    Pet PetEdit(Pet pet,int id);


}