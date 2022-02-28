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
    public Address GetAdress(int id);
    public List<Country> GetAllCountry();
    public Country GetCountry(int id);
    public List<City> GetAllCity();
    public City GetCity(int id);
    public List<State> GetAllState();

    public State GetState(int id);
    public List<District> GetAllDistrict();
    public District GetDistrict(int id);
    public List<Neighborhood> GetAllNeigborhood();
    public Neighborhood GetNeigborhood(int id);
    public List<Street> GetAllStreet();
    public Street GetStreet(int id);








}