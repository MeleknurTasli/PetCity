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

    public Product(){

    }
    public Product(int ID, string Name, string Detail, decimal Price,
    int Stock, int SupplierId, string Brand, int CategoryId)
    {
        this.ID = ID;
        this.Name = Name;
        this.Detail = Detail;
        this.Price = Price;
        this.Stock = Stock;
        this.SupplierId = SupplierId;
        this.Brand = Brand;
        this.CategoryId = CategoryId;
    }
}
