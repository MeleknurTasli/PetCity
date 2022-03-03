
public class AddressRepository : IAddressRepository
{

    PetCityContext _petCityContext;

    public AddressRepository()
    {
        _petCityContext = new PetCityContext();
    }

    public async Task<Address> RegisterAddress()
    {
        return null;
    }


    public async Task<List<Address>> GetAllAddress()
    {

        return await _petCityContext.Set<Address>().ToListAsync();
    }
    public async Task<Address> GetAddress(int id)
    {

        var getAddress = await _petCityContext.Set<Address>().SingleOrDefaultAsync(p => p.Id == id);

        if (getAddress != null)
        {

            return getAddress;

        }
        else
        {
            return null;
        }
    }
    public async Task<Country> GetCountry(string name)
    {

        var countrycontroller =await _petCityContext.Set<Country>().FirstOrDefaultAsync(p => p.Name == name );
        if(countrycontroller != null)
        {
            return countrycontroller;
        }
         return null;
    }


    public async Task<List<Country>> GetAllCountry()
    {

        return await _petCityContext.Set<Country>().ToListAsync();
    }
     async Task<Country> IAddressRepository.CreateCountry(Country country)
    {
        _petCityContext.Country.Add(country);
        _petCityContext.SaveChangesAsync();
        return country;
        
    }

    string name;
    public async Task<List<State>> GetAllStatesByCountryId(int id)
    {
    
        var getState = await _petCityContext.Set<State>().Where(p => p.CountryId == id).ToListAsync();
        if (getState != null)
        {

            return getState;

        }
        else
        {
            return null;
        }
    }

    public async Task<List<City>> GetAllCitiesByStateId(int id)
    {
        var getCity = await _petCityContext.Set<City>().Where(p => p.StateId == id).ToListAsync();
        if (getCity != null)
        {

            return getCity;

        }
        else
        {
            return null;
        }
    }

    public async Task<List<City>> GetAllCitiesByContryId(int id)
    {
        var getCity = await _petCityContext.Set<City>().Where(p => p.CountryId == id).ToListAsync();
        if (getCity != null)
        {

            return getCity;

        }
        else
        {
            return null;
        }
    }

    public async Task<List<District>> GetAllDistrictsByCityId(int id)
    {
        var getDistricts = await _petCityContext.Set<District>().Where(p => p.CityId == id).ToListAsync();
        if (getDistricts != null)
        {

            return getDistricts;

        }
        else
        {
            return null;
        }
    }
    public async Task<Address> DeleteAddress(int id)
    {


        var DeletedAddress = await _petCityContext.Address.FirstOrDefaultAsync(x => x.Id == id);
        _petCityContext.Address.Remove(DeletedAddress);
        _petCityContext.SaveChangesAsync();

        return null;


    }


    public async Task<Address> RegisterAddress(Address address)
    {
        address.City.Name = name;



        return null;
    }



    public Task<Address> UpdateAddress(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<Address>> IAddressRepository.GetAllAddress()
    {
        throw new NotImplementedException();
    }

    Task<Address> IAddressRepository.GetAddress(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<Country>> IAddressRepository.GetAllCountry()
    {
        throw new NotImplementedException();
    }

   

    Task<List<State>> IAddressRepository.GetAllStatesByCountryId(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<City>> IAddressRepository.GetAllCitiesByStateId(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<City>> IAddressRepository.GetAllCitiesByContryId(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<District>> IAddressRepository.GetAllDistrictsByCityId(int id)
    {
        throw new NotImplementedException();
    }

    Task<Address> IAddressRepository.RegisterAddress()
    {
        throw new NotImplementedException();
    }

    Task<Address> IAddressRepository.DeleteAddress(int id)
    {
        throw new NotImplementedException();
    }

    Task<Address> IAddressRepository.UpdateAddress(int id)
    {
        throw new NotImplementedException();
    }
}


