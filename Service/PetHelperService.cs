public class PetHelperService : IPetHelperService
{
    private PetHelperRepository _petHelperRepository;
    public PetHelperService(PetHelperRepository _petHelperRepository)
    {
        this._petHelperRepository = _petHelperRepository;
    }

    public string Add(PetHelper petHelper)
    {
        _petHelperRepository.Add(petHelper);
        return "Ok";
    }

    public PetHelper FindPetHelperByLatLong(string latitude, string longtitude)
    {
        var petHelper = _petHelperRepository.FindPetHelperByLatLong(latitude,longtitude);
        if (latitude != null && longtitude != null)
        {
        return petHelper;
        }
        return null;
    }

    public List<PetHelper> GetPetHelper()
    {
        return _petHelperRepository.GetPetHelper();
    }
}