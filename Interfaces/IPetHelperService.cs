public interface IPetHelperService{
    List<PetHelper> GetPetHelper();
    IResult Add(PetHelper petHelper);
    PetHelper FindPetHelperByLatLong(string latitude, string longtitude);
}