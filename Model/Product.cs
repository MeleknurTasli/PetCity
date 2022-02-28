public class Product {
    public int Id { get; set; }
    public string? Name { get; set; }

    public string? TestPropString { get; set; }
    public int? TestPropInt { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public short QuantityPerUnit { get; set; }
    

    
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public virtual Category? Category { get; set; }

    public int BrandId { get; set; }
    [ForeignKey("BrandId")]
    public virtual Brand? Brand { get; set; }

    public int CompanyId { get; set; }
    [ForeignKey("CompanyId")]
    public virtual Company? Company { get; set; }
    
}