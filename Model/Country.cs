public class Country{
    public int Id{ get; set; }
    public string CountryName { get; set; }
    public int CountryCode { get; set; }
    public State? State { get; set; }
    public City? City { get; set; }

    /////////////////////////////
    public Address Address { get; set; }
    public ICollection<State> StateList { get; set; }
    public ICollection<City> CityList { get; set; }

}