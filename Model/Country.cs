public class Country{
    public int CountryID { get; set; }
    public string CountryName { get; set; }
    public int CountryCode { get; set; }
    public State ?state { get; set; }
    public City ?city { get; set; }
    public List<Country> list = new List<Country>();
    public Country(int Id, string Name, int CountryCode)
    {

        this.CountryID = Id;
        this.CountryName = Name;
        this.CountryCode = CountryCode;
        list.Add(new Country(Id, Name, CountryCode));
    }

}