public class AddressService : IAddressService
{
    private IAddressRepository _addressRepository;
    public PetCityContext _petCityContext;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }


    public async Task<Address> GetAddress(int id)
    {
        if (id != null)
        {
            return await _addressRepository.GetAddress(id);

        }
        return null;
    }

    public async Task<List<Address>> GetAllAddresses()
    {
        return await _addressRepository.GetAllAddress();
    }

    public async Task<List<City>> GetAllCitiesByContryId(int id)
    {
        return await _addressRepository.GetAllCitiesByContryId(id);
    }

    public async Task<List<City>> GetAllCitiesByStateId(int id)
    {
        return await _addressRepository.GetAllCitiesByStateId(id);
    }

    public async Task<List<Country>> GetAllCountries()
    {
        return await _addressRepository.GetAllCountry();
    }

    public async Task<List<District>> GetAllDistrictsByCityId(int id)
    {
        return await _addressRepository.GetAllDistrictsByCityId(id);
    }



    public async Task<List<State>> GetAllStatesByCountryId(int id)
    {
        return await _addressRepository.GetAllStatesByCountryId(id);
    }

    public async Task<Address> DeleteAddress(int id)
    {
        return await _addressRepository.DeleteAddress(id);
    }
    public async Task<Address> RegisterAddress()
    {
        return await _addressRepository.RegisterAddress();
    }

    public async Task<Address> UpdateAddress(int id)
    {
        return await _addressRepository.UpdateAddress(id);
    }


    Task<Country> IAddressService.CreateCountry(Country country)
    {
        _petCityContext = new PetCityContext();

        var controller = _petCityContext.Country.FirstOrDefault(x => x.Name == country.Name);
        if (controller == null)
        {

            return _addressRepository.CreateCountry(country);
        }
        else
        {
            //Hata mesajı verilecek
            return null;
        }


    }

    Task<City> IAddressService.CreateCity(City city)
    {
        _petCityContext = new PetCityContext();

        var controller = _petCityContext.City.FirstOrDefault(x => x.Name == city.Name);
        if (controller == null)
        {

            return _addressRepository.CreateCity(city);
        }
        else
        {
            //Hata mesajı verilecek
            return null;
        }
    }

    Task<State> IAddressService.CreateState(State state)
    {
        _petCityContext = new PetCityContext();

        var controller = _petCityContext.State.FirstOrDefault(x => x.Name == state.Name);
        if (controller == null)
        {

            return _addressRepository.CreateState(state);
        }
        else
        {
            //Hata mesajı verilecek
            return null;
        }
    }

    Task<District> IAddressService.CreateDistrict(District district)
    {
        _petCityContext = new PetCityContext();

        var controller = _petCityContext.District.FirstOrDefault(x => x.Name == district.Name);
        if (controller == null)
        {

            return _addressRepository.CreateDistrict(district);
        }
        else
        {
            //Hata mesajı verilecek
            return null;
        }
    }

    Task<Country> IAddressService.DeleteCountry(Country country)
    {
        _petCityContext = new PetCityContext();
        var controller = _petCityContext.Country.FirstOrDefault(x => x.Name== country.Name);
        if (controller != null)
        {
            return _addressRepository.DeleteCountry(country);
        }
        else
        {
        
         //Hata mesajı verilecek
            return null;
        }
       
    }
}



