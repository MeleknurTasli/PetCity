public class PetHelperRepository
{
    public static PetHelperDTO FindPetHelperByLatLong(string latitude, string longtitude){
        var result = PetHelperDTO.petHelperStatic.SingleOrDefault(p => p.Latitude == latitude && p.Longtitude == longtitude);
        return result;

    }
    
}