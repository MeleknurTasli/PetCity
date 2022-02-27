public class Category{
    public int CategoryId { get; set; }
    public string? Name { get; set; } 
    public virtual ICollection<Product>? Products { get; set; }

        public override string ToString() {
        var txt = new StringBuilder();
        txt.AppendLine($"Id: {CategoryId}");
        txt.AppendLine($"Category: {Name}");
        
        return txt.ToString();
    }
}