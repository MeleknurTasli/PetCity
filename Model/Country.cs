using System.Collections.Generic;

public class Country
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int CountryCode { get; set; }

    public List<Country> list = new List<Country>();

    public Country(int Id, string Name, int CountryCode)
    {

        this.Id = Id;
        this.Name = Name;
        this.CountryCode = CountryCode;


        list.Add(new Country(Id, Name, CountryCode));
    }



}
