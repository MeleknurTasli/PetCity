public class Neighborhood{
    public int NeighnorhoodID { get; set; }
    public string NeighborhoodName { get; set; }
    public Street Street { get; set; }
    /////////////////////////////
    public District District { get; set; }
    public ICollection<Street> StreetList { get; set; }


}