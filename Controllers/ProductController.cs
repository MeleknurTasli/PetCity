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
        MockData.ProductMockDataList.Add(product);
        return "Ok";
    }

    [HttpGet("{name}")]
    public Product? GetProductByName(string name)
    {
        Product? product = MockData.ProductMockDataList.FirstOrDefault(x => x.Name == name);
        return product;
    }
    [HttpGet("{Brand}")]
    public Product? GetProductByBrand(string Brand){
        return _productService.GetProductByBrand(Brand);
    }

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