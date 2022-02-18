public class PetHelperDTO{

  
    public static List<PetHelperDTO> petHelperStatic = new List<PetHelperDTO>();
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Image { get; set; }
    public DateTime Date { get; set; }
    public string Latitude { get; set; }
    public string Longtitude { get; set; }
    public string Description { get; set; }
      public PetHelperDTO()
    {
        
    }

}