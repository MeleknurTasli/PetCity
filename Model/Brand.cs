public class Brand
{
    public int BrandId { get; set; }
    public string? Name { get; set; }
    public virtual ICollection<Product>? Products { get; set; }

    public override string ToString()
    {
        var txt = new StringBuilder();
        txt.AppendLine($"Id: {BrandId}");
        txt.AppendLine($"Brand: {Name}");

        return txt.ToString();
    }
}