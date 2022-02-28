public class City{
    public int CityId { get; set; }
    public string Name { get; set; }
     public State State { get; set; }
     public int StateId { get; set; }
    public Country Country { get; set; }
    public int CountryId { get; set; }
     public List<District> District { get; set; }
}