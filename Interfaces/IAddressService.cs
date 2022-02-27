using System.Collections.Generic;

public interface IAddressService
{

    // public string SetAddress(Address address);
    // public List<Address> GetAllPetAddress();
    //  public List<Address> GetAllPetAddress(string genus);
    // public List<Address> GetAllPetByCountry(string country, string genus);
    // public List<Address> GetAllPetByState(string state, string genus);
    // public List<Address> GetAllPetByCity(string city, string genus);

    public List<Address> GetAllAdress();
    public List<Address> GetAdress(int id);
    public List<Country> GetAllCountry();
    public List<Country> GetCountry(int id);
    public List<City> GetAllCity();
    public List<City> GetCity(int id);
    public List<State> GetAllState();
    public List<State> GetState(int id);
    public List<District> GetAllDistricts();
    public List<District> GetDistricts(int id);
    
    public List<Neighborhood> GetAllNeigborhoods();
    public List<Neighborhood> GetNeigborhoods(int id);
        public List<Street> GetAllStreet();
    public List<Street> GetStreet(int id);








}