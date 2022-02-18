using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public List<Product> GetProduct()
    {
        return MockData.ProductMockDataList;
    }

    [HttpPost]
    public string Create(Product product)
    {
        MockData.ProductMockDataList.Add(product);
        return "Ok";
    }

    [HttpGet("{name}")]
    public ProductDTO? GetProductByName(string name)
    {
        ProductDTO? product = ProductDTO.staticList.FirstOrDefault(x => x.Name == name);
        return product;
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