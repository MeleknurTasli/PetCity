public class City{
    public int Id { get; set; }
    public string Name { get; set; }
    public Country Country { get; set; }
    public State? State { get; set; }
    public virtual ICollection<District>? District { get; set; }
}