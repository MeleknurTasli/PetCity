public class Neighborhood{
    public int NeighborhoodId { get; set; }
    public string Name { get; set; }
    public District District { get; set; }
    public int DistrictId { get; set; }
    public List<Street> StreetList { get; set; }


}