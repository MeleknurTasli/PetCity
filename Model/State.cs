public class State{
    public int StateID { get; set; }
    public string StateName { get; set; }
    public City? City { get; set; }

    public List<State> list = new List<State>();

}