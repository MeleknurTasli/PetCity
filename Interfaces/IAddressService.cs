using System.Collections.Generic;

public interface IAddressService
{
   Task<List<Address>> GetAllAddresses();
    Task<Address> GetAddress(int id);

  
    Task<List<Country>> GetAllCountries();
   Task<Country> CreateCountry(Country country);
    Task<List<State>> GetAllStatesByCountryId(int id);
    Task<List<City>> GetAllCitiesByStateId(int id);
    Task<List<City>> GetAllCitiesByContryId(int id);
    Task<List<District>> GetAllDistrictsByCityId(int id);
      Task< Address> RegisterAddress();
    Task< Address> DeleteAddress(int id);
    Task< Address> UpdateAddress(int id);

}