public class Address
{
    public int AddressId { get; set; }
    public string AddressName { get; set; }
    public string OpenAddres1 { get; set; }
    public string OpenAddres2 { get; set; }
    public virtual ICollection<Country> Country { get; set; }


    public Address()
    {
        
    }

}