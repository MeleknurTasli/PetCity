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
    public string setProduct(ProductDTO product){
        ProductDTO.staticList.Add(product);
        return "OK";
    }

}
