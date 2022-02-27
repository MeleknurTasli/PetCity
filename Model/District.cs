public class District
{
    public int DistrictID { get; set; }
    public string DistrictName { get; set; }
    public Neighborhood Neighborhood { get; set; }

    ////////////////////////////////
    public City City { get; set; }
    public ICollection<Neighborhood> NeighborhoodList { get; set; }


}