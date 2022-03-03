public class Address
{
    public int Id { get; set; }
    public string AddressName { get; set; }
    public string OpenAddres1 { get; set; }
    public string OpenAddres2 { get; set; }
    // public int CountryId { get; set; }
    // public int CityId { get; set; }
    // public int? StateId { get; set; }
    // public int DistrictId { get; set; }
    public Country Country { get; set; }
    public City City { get; set; }
    public State? State { get; set; } 
    public District District { get; set; }

}