public class City{
    public int CityId { get; set; }
    public string Name { get; set; }
     public State State { get; set; }
    public Country Country { get; set; }
    public int CountryId { get; set; }
     public List<District> DistrictList { get; set; }
}