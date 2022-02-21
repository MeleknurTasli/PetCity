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
      Product? p = _productService.Create(product);
      if(p!=null){
          return Ok("Ekleme Başarılı");
      }
        
       return BadRequest("Ekleme Başarısız");
       
    }

    [HttpGet]
    [Route("productName")]
    public IActionResult GetProductByName(string name)
    {   
        Product? InComingProduct = _productService.GetProductByName(name);
        if(InComingProduct == null){
            return BadRequest("Ürün bulunamadı");
        }
        return Ok(InComingProduct);
    }

    [HttpGet]
    [Route("brandName")]
    public IActionResult GetProductByBrand(string name){
        Product? IncomingProduct = _productService.GetProductByBrandName(name);
        if(IncomingProduct == null){
            return BadRequest("Marka bulunamadı");
        }
        return Ok(IncomingProduct);
    }

    [HttpGet]
    [Route("orderByName")]
    public IActionResult GetProductOrderByName(Boolean IsDescending){
        List<Product> InComingList = _productService.GetProductOrderByName(IsDescending);
        if(InComingList == null){
            return BadRequest("Ürünler listelenemedi");
        }
        return Ok(InComingList);
    }

   [HttpDelete("{id}")]
   public IActionResult Delete(int id) {
       bool IsDeleted =_productService.Delete(id);

       if (IsDeleted) {
           return NoContent();
       }

       return BadRequest("Kayıt silinemedi");
   }

   [HttpPut("{id}")]
   public IActionResult Update([FromRoute]int id, [FromBody]Product p) {
       Product product = _productService.Update(id, p);
        if (p != null) {
            return Ok(product);
        }

        return BadRequest("Güncelleme işlemi başarısız");
   }
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