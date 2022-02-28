public class Country
{
    public int CountryId { get; set; }
    public string? CountryName { get; set; }
    public int? CountryCode { get; set; }

    public virtual ICollection<City> city { get; set; }


}