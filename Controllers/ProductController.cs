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
    public IActionResult GetAllProducts()
    {
        
        return Ok(_productService.GetAll());
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
      Product p= _productService.Create(product);
      if(p!=null){
          return Ok("Ekleme Başarılı");
      }
        
       return BadRequest("Ekleme Başarısız");
       
    }

    [HttpGet]
    [Route("product/productName/{name}")]
    public IActionResult GetProductByName(string name)
    {   
        Product? InComingProduct = _productService.GetProductByName(name);
        if(InComingProduct == null){
            return BadRequest("Ürün bulunamadı");
        }
        return Ok(InComingProduct);
    }

    [HttpGet]
    [Route("product/brandName/{name}")]
    public IActionResult GetProductByBrand(string name){
        Product? IncomingProduct = _productService.GetProductByBrandName(name);
        if(IncomingProduct == null){
            return BadRequest("Marka bulunamadı");
        }
        return Ok(IncomingProduct);
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