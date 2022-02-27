public class Country{
    public int CountryID { get; set; }
    public string CountryName { get; set; }
    public int CountryCode { get; set; }
    public State? state { get; set; }
    public City? city { get; set; }


}