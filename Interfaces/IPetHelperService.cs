public interface IPetHelperService{
    List<PetHelper> GetPetHelper();
    string Add(PetHelper petHelper);
    PetHelper FindPetHelperByLatLong(string latitude, string longtitude);
}