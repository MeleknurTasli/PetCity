public class ProductService : IProductService
{
    ProductRepository productRepository;
    public ProductService()
    {
       productRepository = new ProductRepository();   
    }
    public Product Create(Product product)
    {
        Product? p = productRepository.GetProductByName(product.Name);

        if (p != null) {
            productRepository.Create(product);
        }

        return product;
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product? GetProductByName(string name)
    {
        throw new NotImplementedException();
    }
    public Product? GetProductByBrand(string Brand){
        return productRepository.GetProductByBrand(Brand);
    }
}