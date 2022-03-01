public class Address
{
    public int Id { get; set; }
    public string AddressName { get; set; }
    public string OpenAddres1 { get; set; }
    public string OpenAddres2 { get; set; }
    public Country Country { get; set; }
    public City City { get; set; }
    public State? State { get; set; } 
    public District District { get; set; }
    public Neighborhood Neighborhood { get; set; }
    public Street Street { get; set; }


    


}