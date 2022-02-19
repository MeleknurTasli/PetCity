public class PetRepository
{
    public Pet PetEdit(Pet petDTO, int id)
    {
        var editedPet = MockData.PetMockDataList.FirstOrDefault(x => x.id == id);
        editedPet.name = petDTO.name;
        editedPet.About = petDTO.About;
        editedPet.BirthDate = petDTO.BirthDate;
        editedPet.Family = petDTO.Family;
        editedPet.Gender = petDTO.Gender;
        editedPet.Genus = petDTO.Genus;
        editedPet.UserID = petDTO.UserID;
        return editedPet;
    }
}