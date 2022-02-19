<<<<<<< HEAD
<<<<<<< HEAD:DTO/ProductDTO.cs
public class ProductDTO{

    public static List<ProductDTO> staticList = new List<ProductDTO>
    {
        new ProductDTO() 
        {
            ID = 1,
            Name = "Minnak",
            Detail = "fdsfsdf",
            Price = 12.45m,
            Stock = 12,
            SupplierId = 10,
            Brand = "sadsad",
            CategoryId = 3
        },
         new ProductDTO() 
        {
            ID = 2,
            Name = "Test",
            Detail = "fdsfsdf",
            Price = 22.45m,
            Stock = 10,
            SupplierId = 15,
            Brand = "sadsad",
            CategoryId = 2
        },
         new ProductDTO() 
        {
            ID = 3,
            Name = "Minnak",
            Detail = "fdsfsdf",
            Price = 20.45m,
            Stock = 45,
            SupplierId = 4,
            Brand = "sadsad",
            CategoryId = 1
        }
    };

    public int ID {get;set;}
=======
public class Product
{
    public int ID { get; set; }
>>>>>>> dev/main:Model/Product.cs
=======
public class Product
{
    public int ID { get; set; }
>>>>>>> e5aea4f57f0693131edec9e92897945d9912b4c6
    public string Name { get; set; }
    public string Detail { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int SupplierId { get; set; }
    public string Brand { get; set; }
    public int CategoryId { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD:DTO/ProductDTO.cs
    
}
/*
{"id":1,
 "Name": "Minnak",
 "Detail":"fdsfsdf",
 "Price":12.45,
 "Stock":12,
 "SupplierId":10,
 "Brand":"sadsad",
 "CategoryId":2}
 */
=======
=======
>>>>>>> e5aea4f57f0693131edec9e92897945d9912b4c6

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
<<<<<<< HEAD
>>>>>>> dev/main:Model/Product.cs
=======
>>>>>>> e5aea4f57f0693131edec9e92897945d9912b4c6
