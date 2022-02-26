using Newtonsoft.Json;
public class MainClass{

    static void Main(){

    }

     public static List<Pet> LoadJson(){
        using(StreamReader reader = new StreamReader(@"data.json")){
            string json = reader.ReadToEnd();
            List<Pet> ?users = JsonConvert.DeserializeObject<List<Pet>>(json);
            return users;
        }      
    }

}

public class Pet{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string PetImageUrl { get; set; }
    public PetGender Gender{get; set;}
    public string Species { get; set; }
    public string SubSpecies { get; set; }
    //public HealthStatus HealthStatus { get; set; }

}