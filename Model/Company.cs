public class Company
{
    public int CompanyId { get; set; }
    public string? Name { get; set; }
    public virtual ICollection<Product>? Products { get; set; }

    public override string ToString()
    {
        var txt = new StringBuilder();
        txt.AppendLine($"Id: {CompanyId}");
        txt.AppendLine($"Company: {Name}");

        return txt.ToString();
    }
}