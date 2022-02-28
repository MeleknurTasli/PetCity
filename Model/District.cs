public class District
{
    public int DistrictId { get; set; }
    public string? Name { get; set; }
    public City? City { get; set; }
    public int CityId { get; set; }
    public State? State { get; set; }
    public int? StateId { get; set; }
    public List<Neighborhood>? NeighborhoodList { get; set; }


}