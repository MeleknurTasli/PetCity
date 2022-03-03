public class AddressService : IAddressService
{
    private IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }



    public async Task<Address> GetAddress(int id)
    {
        if (id != null)
        {
            return _addressRepository.GetAddress(id);

        }
        return null;
    }

    public async Task<List<Address>> GetAllAddresses()
    {
        return  _addressRepository.GetAllAddress();
    }

    public async Task<List<City>> GetAllCitiesByContryId(int id)
    {
        return  _addressRepository.GetAllCitiesByContryId(id);
    }


    public async Task<List<City>> GetAllCitiesByStateId(int id)
    {
        return  _addressRepository.GetAllCitiesByContryId(id);
    }

    public async Task<List<Country>> GetAllCountries()
    {
        return  _addressRepository.GetAllCountry();
    }

    public async Task<List<District>> GetAllDistrictsByCityId(int id)
    {
        return  _addressRepository.GetAllDistrictsByCityId(id);
    }

  

    public async Task<List<State>> GetAllStatesByCountryId(int id)
    {
        return  _addressRepository.GetAllStatesByCountryId(id);
    }

    public async Task<Address> DeleteAddress(int id)
    {
        return  _addressRepository.DeleteAddress(id);
    }
    public async Task<Address> RegisterAddress()
    {
        return  _addressRepository.RegisterAddress();
    }

    public async Task<Address> UpdateAddress(int id)
    {
        return  _addressRepository.UpdateAddress(id);
    }



}


