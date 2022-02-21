public interface IPetHelperService{
    ServiceResponse<List<PetHelper>> GetPetHelper();
    IResult Add(PetHelper petHelper);
    ServiceResponse <PetHelper> FindPetHelperByLatLong(string latitude, string longtitude);
}