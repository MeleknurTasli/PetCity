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

    public IDataResult<PetHelper> FindPetHelperByLatLong(string latitude, string longtitude)
    {
        var petHelper = _petHelperRepository.FindPetHelperByLatLong(latitude,longtitude);
        if (latitude != null && longtitude != null)
        {
        return new SuccessDataResult<PetHelper>(petHelper.Data);
        }
        return null;
    }

    public IDataResult<List<PetHelper>> GetPetHelper()
    {
        return new SuccessDataResult<List<PetHelper>>(_petHelperRepository.GetPetHelper().Data) ;
    }


}