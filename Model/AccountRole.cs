public class AccountRole
{
    public int Id { get; set; }


    [ForeignKey("AccountId")]

    public int account_id { get; set; }
    public virtual Account account { get; set; }

    public int role_id { get; set; }
    [ForeignKey("RoleId")]
    public virtual Role role {get; set;}
}