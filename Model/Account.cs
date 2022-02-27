public class Account {
    public int ID { get; set; }
    public string EMAIL { get; set; }
    public string PASSWORD { get; set; }
    public bool ISBLOCKED { get; set; }
    public bool VISIBILITY { get; set; }
    public Account()
    {
        
    }
    public Account(int id,string email,string password,bool isblocked,bool visibility)
    {
        this.ID=id;
        this.EMAIL=email;
        this.PASSWORD=password;
        this.ISBLOCKED=isblocked;
        this.VISIBILITY=visibility;
    }
}
