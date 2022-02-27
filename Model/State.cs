public class State{
    public int StateID { get; set; }
    public string StateName { get; set; }
    public City? City { get; set; }
    //////////////////////////////
    public Country Country { get; set; }
    public ICollection<City> CityList { get; set; }

}