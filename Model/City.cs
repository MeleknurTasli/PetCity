public class City{
    public int CityID { get; set; }
    public string CityName { get; set; }
    public District District { get; set; }

    ///////////////////////////////////////
    
     public State? State { get; set; }
    public Country? Country { get; set; }
     public ICollection<District> DistrictList { get; set; }
}