public class PetRepository{



    public PetDTO PetEdit(PetDTO petDTO,int id){


        var  editedPet = PetDTO.PetList.FirstOrDefault(x=>x.id ==id);
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