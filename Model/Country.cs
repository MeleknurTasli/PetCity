public class Country{
    public int Id{ get; set; }
    public string CountryName { get; set; }
    public int CountryCode { get; set; }
    public State? state { get; set; }
    public City? city { get; set; }


}