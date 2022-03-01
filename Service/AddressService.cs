public class AddressService : IAddressService
{
    private AddressRepository _addressRepository;

    public AddressService()
    {
        _addressRepository = new AddressRepository();
    }

    public async Task<List<Address>> GetAdress(int id)
    {
        if (id != null)
        {
            return await _addressRepository.GetAdress(id);

        }
        return null;
    }

    public async Task<List<Address>> GetAllAddresses()
    {
        return await _addressRepository.GetAllAddresses();
    }

    public async Task<List<City>> GetAllCitiesByContryId(int id)
    {
        return await _addressRepository.GetAllCitiesByContryId(id);
    }

 >
     public async Task<List<City>> GetAllCitiesByStateId(int id)
    {
        return await _addressRepository.GetAllCitiesByContryId(id);
    }
    
    public async Task<List<Address>> GetAllCountries()
    {
        return await _addressRepository.GetAllCountry();
    }

    public async Task<List<District>> GetAllDistrictsByCityId(int id)
    {
        return await _addressRepository.GetAllDistrictsByCityId(id);
    }

    public async Task<List<Neighborhood>> GetAllNeighborhoodsByDistrictId(int id)
    {
        return await _addressRepository.GetAllNeighborhoodsByDistrictId(id);
    }

    public async Task<List<State>> GetAllStatesByCountryId(int id)
    {
        return await _addressRepository.GetAllStatesByCountryId(id);
    }

    public async Task<List<Street>> GetAllStreetsByNeighborhoodtId(int id)
    {
        return await _addressRepository.GetAllStreetsByNeighborhoodtId(id);

    }
    public async Task<Address> RegisterAddress()
    {
        return await _addressRepository.RegisterAddress();
    }

    public async Task<Address> UpdateAddress(int id)
    {
        return await _addressRepository.UpdateAddress(id);
    }

    public async Task<Address> DeleteAddress(int id)
    {
        return await _addressRepository.DeleteAddress(id);
    }
}


