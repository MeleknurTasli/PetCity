public class PetHelperService : IPetHelperService
{
    private IPetHelperRepository _petHelperRepository;
    public PetHelperService(IPetHelperRepository petHelperRepository)
    {
        this._petHelperRepository = petHelperRepository;
    }

    public IResult Add(PetHelper petHelper)
    {
        _petHelperRepository.Add(petHelper);
        return new SuccessResult();
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