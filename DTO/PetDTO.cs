public class PetDTO {
    public static List<PetDTO> PetList=new List<PetDTO>();
    public int id { get; set; }
    public string  name { get; set; }
    public DateTime BirthDate { get; set; }
    public Family Family { get; set; }
    public Gender Gender { get; set; }
    public string Genus { get; set; }
        public int UserID { get; set; }
    public string About { get; set; }


public PetDTO(int id){

    this.id=id;
}

}