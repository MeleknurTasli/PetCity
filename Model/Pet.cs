public class Pet{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string PetImageUrl { get; set; }
    public PetGender Gender{get; set;}
    public string Species { get; set; }
    public string SubSpecies { get; set; }
    HealthStatus HealthStatus { get; set; }

}