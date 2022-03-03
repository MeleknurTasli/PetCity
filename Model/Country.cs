public class Country{
    public int CountryId{ get; set; }
    public string? CountryName { get; set; }
    public int? CountryCode { get; set; }
    public Address? Address { get; set; }
    public int? AddressId { get; set; }
    public virtual ICollection<State>? State { get; set; }
    public virtual ICollection<City>? City { get; set; }

    public Country()
    {
    
    }

}