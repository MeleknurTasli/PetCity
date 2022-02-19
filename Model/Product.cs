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
    public string Name { get; set; }
    public string Detail { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int SupplierId { get; set; }
    public string Brand { get; set; }
    public int CategoryId { get; set; }
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

    public Product(int Id)
    {
        this.ID = Id;
    }
}
>>>>>>> dev/main:Model/Product.cs
