using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public List<ProductDTO> GetProduct()
    {
        return ProductDTO.staticList;
    }

    [HttpPost]
    public string Create(ProductDTO product)
    {
        ProductDTO.staticList.Add(product);
        return "Ok";
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