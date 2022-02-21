using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;
    public ProductController(IProductService productService)
    {
        _productService = productService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();
    }

    [HttpGet]
    public ActionResult<ServiceResponse<List<Product>>> GetAllProducts()
    {
        return ResponseGeneratorHelper.ResponseGenerator<List<Product>>(_productService.GetAll());
    }

    [HttpPost]
    public ActionResult<ServiceResponse<Product>> Create(Product product)
    {
        return ResponseGeneratorHelper.ResponseGenerator<Product>(_productService.Create(product));
    }

    [HttpGet("ProductByName")]
    public ActionResult<ServiceResponse<Product>> GetProductByName([FromQuery]string name)
    {   
        return ResponseGeneratorHelper.ResponseGenerator<Product>(_productService.GetProductByName(name));
    }

    [HttpGet("ProductByBrand")]
    public IActionResult GetProductByBrand(string name){
        Product? IncomingProduct = _productService.GetProductByBrandName(name);
        if(IncomingProduct == null){
            return BadRequest("Marka bulunamadı");
        }
        return Ok(IncomingProduct);
    }

   [HttpDelete("id")]
   public ActionResult<ServiceResponse<Product>> Delete(int id) {
       return ResponseGeneratorHelper.ResponseGenerator<Product>(_productService.Delete(id));
   }

    [HttpPut("{id}")]
   public IActionResult Update([FromQuery]int id, [FromBody]Product p) {
       Product product = _productService.Update(id, p);
        if (p != null){
            return Ok(product);
        }

        return BadRequest("Güncelleme işlemi başarısız");
   }

  
}
