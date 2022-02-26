using System.Collections.Generic;

public class State
{

    public int Id { get; set; }
    public string Name { get; set; }
    public Country country { get; set; }

    public List<State> list = new List<State>();

    public State(int Id, string Name, Country country)
    {

        this.Id = Id;
        this.Name = Name;
        this.country = country;

        list.Add(new State(Id, Name,country));
    }


}
