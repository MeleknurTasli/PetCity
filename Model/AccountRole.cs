public class AccountRole{
    public int Id { get; set; }
    public Account account { get; set; }
    public List<Role> ListOfRoles { get; set; }
}