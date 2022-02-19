public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Detail { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int SupplierId { get; set; }
    public string Brand { get; set; }
    public int CategoryId { get; set; }

    public Product(int Id)
    {
        this.ID = Id;
    }
}