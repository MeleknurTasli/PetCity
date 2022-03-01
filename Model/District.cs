public class District
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public City? City { get; set; }
    public virtual ICollection<Neighborhood>? Neighborhood { get; set; }


}