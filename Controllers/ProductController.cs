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
    public ActionResult<ServiceResponse<List<Product>>> GetProductsByBrandName([FromQuery]string name){
        return ResponseGeneratorHelper.ResponseGenerator<List<Product>>(_productService.GetProductsByBrandName(name));
    }
    [HttpGet("ProductInStock")]
    public ActionResult<ServiceResponse<List<Product>>> GetProductInStock()
    {
        return ResponseGeneratorHelper.ResponseGenerator<List<Product>>(_productService.GetProductsInStock());
    }

   [HttpDelete("id")]
   public ActionResult<ServiceResponse<Product>> Delete(int id) {
       return ResponseGeneratorHelper.ResponseGenerator<Product>(_productService.Delete(id));
   }

    [HttpPut("{id}")]
   public ActionResult<ServiceResponse<Product>> Update([FromQuery]int id, [FromBody]Product p) {
       return ResponseGeneratorHelper.ResponseGenerator<Product>(_productService.Update(id, p));
   }

    [HttpGet("DescendingByName")]
    public ActionResult<ServiceResponse<List<Product>>> OrderByNameDescending() {
        return ResponseGeneratorHelper.ResponseGenerator<List<Product>>(_productService.GetProductsOrderByNameDescending());
    }

     [HttpGet("AscendingByName")]
    public ActionResult<ServiceResponse<List<Product>>> OrderByNameAscending() {
        return ResponseGeneratorHelper.ResponseGenerator<List<Product>>(_productService.GetProductsOrderByNameAscending());
    }

     [HttpGet("DescendingByPrice")]
    public ActionResult<ServiceResponse<List<Product>>> OrderPriceDescending() {
        return ResponseGeneratorHelper.ResponseGenerator<List<Product>>(_productService.GetProductsOrderByPriceDescending());
    }

     [HttpGet("AscendingByPrice")]
    public ActionResult<ServiceResponse<List<Product>>> OrderPriceAsscending() {
        return ResponseGeneratorHelper.ResponseGenerator<List<Product>>(_productService.GetProductsOrderByPriceAscending());
    }
}
