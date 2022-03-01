public class Neighborhood{
    public int Id { get; set; }
    public string Name { get; set; }
    public District District { get; set; }
    public virtual ICollection<Street> Street { get; set; }

}