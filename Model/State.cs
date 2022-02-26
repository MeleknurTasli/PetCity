public class State{
    public int StateID { get; set; }
    public string StateName { get; set; }
    public City ?City { get; set; }

    public List<State> list = new List<State>();

    public State(int Id, string Name, Country country)
    {

        this.StateID = Id;
        this.StateName = Name;

        list.Add(new State(Id, Name,country));
    }

}