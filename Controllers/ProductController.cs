using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public List<Product> GetAllProducts()
    {
        return _productService.GetAll();
    }

    [HttpPost]
    public string Create(Product product)
    {
      Product p= _productService.Create(product);
      if(p!=null){
          return "Ekleme başarılı";
      }
        
       return "Başarısız";
    }

    [HttpGet("{name}")]
    public Product? GetProductByName(string name)
    {
       return _productService.GetProductByName(name);
    }
    [HttpGet("{Brand}")]
    public Product? GetProductByBrand(string Brand){
        return _productService.GetProductByBrand(Brand);
    }

    // [HttpPost("{val}")]
    // public string GetProductsOrderByPrice(bool val)
    // {
    //     bool test = val;
    //     if (test) 
    //     {
    //         return "true";
    //     }

    //     return "false";
    // }

}
/*
{
    "id":1,
 "Name": "Minnak",
 "Detail":"fdsfsdf",
 "Price":12.45,
 "Stock":12,
 "SupplierId":10,
 "Brand":"sadsad",
 "CategoryId":2
 }
*/