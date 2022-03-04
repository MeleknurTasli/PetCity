using System.Collections.Generic;

public interface IAddressRepository
{
    Task<List<Address>> GetAllAddress();
    Task<Address> GetAddress(int id);
    Task<List<Country>> GetAllCountry();
    Task<List<State>> GetAllStatesByCountryId(int id);
    Task<List<City>> GetAllCitiesByStateId(int id);
    Task<List<City>> GetAllCitiesByContryId(int id);
    Task<List<District>> GetAllDistrictsByCityId(int id);
    Task<Address> RegisterAddress();
    Task<Address> DeleteAddress(int id);
    Task<Address> UpdateAddress(int id);
    Task<Country> CreateCountry(Country country);
    Task<City> CreateCity(City city);
    Task<State> CreateState(State state);
    Task<District> CreateDistrict(District district);
     Task<Country> DeleteCountry(Country country);




}