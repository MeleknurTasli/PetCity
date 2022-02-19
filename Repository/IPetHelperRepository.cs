public interface IPetHelperRepository{
    IResult Add(PetHelper petHelper);
    PetHelper FindPetHelperByLatLong(string latitude, string longtitude);
    List<PetHelper> GetPetHelper();
}