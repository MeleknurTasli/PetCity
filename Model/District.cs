public class District
{
    public int DistrictId { get; set; }
    public string? Name { get; set; }
    public City? City { get; set; }
    public int CityId { get; set; }
    public List<Neighborhood>? Neighborhood { get; set; }


}