public class Country{
    public int CountryId{ get; set; }
    public string? CountryName { get; set; }
    public int? CountryCode { get; set; }
    public Address? Address { get; set; }
    public int? AddressId { get; set; }
    public List<State>? State { get; set; }
    public List<City>? City { get; set; }

}