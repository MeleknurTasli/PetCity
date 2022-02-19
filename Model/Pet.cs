public class Pet {
    public int id { get; set; }
    public string  name { get; set; }
    public DateTime BirthDate { get; set; }
    public Family Family { get; set; }
    public Gender Gender { get; set; }
    public string Genus { get; set; }
    public int UserID { get; set; }
    public string About { get; set; }


public Pet(int id){

    this.id=id;
}

}