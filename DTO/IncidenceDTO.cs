public class IncidenceDTO
{
    
    public string? Name { get; set; }
    public Region? Region { get; set; }
    public DateTime? Date { get; set; }
    public bool Visibility { get; set; }
    public string? Image { get; set; }
    public string? Description { get; set; }

    public IncidenceDTO(Incidence incidence)
    {
        Name = incidence.Name;
        Region = incidence.Region;
        Date = incidence.Date;
        Visibility = incidence.Visibility;
        Image = incidence.Image;
        Description = incidence.Description;
    }
}