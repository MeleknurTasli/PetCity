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
        return productRepository.Create(product);
    }

    public List<Product> GetAll()
    {
        return productRepository.GetAll();
    }

    public Product? GetProductByName(string name)
    {
        return productRepository.GetProductByName(name);
    }
    public Product? GetProductByBrand(string Brand){
        return productRepository.GetProductByBrand(Brand);
    }

    public List<Product> GetProductOrderByPrice(bool IsDescending)
    {
        return productRepository.GetProductOrderByPrice(IsDescending); 
    }

    public List<Product> GetProductsByCategoryName(int CategoryId)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProductsGreaterThen(decimal min)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProductsLessThen(decimal max)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProductsBetweenMinMaxPrice(decimal min, decimal max)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProductsInStock()
    {
        throw new NotImplementedException();
    }
}