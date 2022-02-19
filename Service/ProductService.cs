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
    public Product? GetProductByBrandName(string Brand){
        return productRepository.GetProductByBrand(Brand);
    }

    public List<Product> GetProductOrderByName(bool IsDescending) {
         return productRepository.GetProductOrderByName(IsDescending);
    }

    public List<Product> GetProductOrderByPrice(bool IsDescending) {
        return productRepository.GetProductOrderByPrice(IsDescending); 
    }

    public List<Product> GetProductsByCategoryName(int CategoryId)
    {
        return productRepository.GetProductsByCategoryName(CategoryId);
    }

    public List<Product> GetProductsGreaterOrEqualsThen(decimal min)
    {
        return productRepository.GetProductsGreaterOrEqualsThen(min);
    }

    public List<Product> GetProductsLessOrEqualsThen(decimal max)
    {
        return productRepository.GetProductsLessOrEqualsThen(max);
    }

    public List<Product> GetProductsBetweenMinMaxPrice(decimal min, decimal max)
    {
        return productRepository.GetProductsBetweenMinMaxPrice(min, max);
    }

    public List<Product> GetProductsInStock()
    {
        return GetProductsInStock();
    }

    public List<Product> GetProductsByCategory(int CategoryId)
    {
        return productRepository.GetProductsByCategoryName(CategoryId);
    }

    public Product Update(int id, Product product)
    {
        return productRepository.Update(id, product);
    }

    public bool Delete(int id)
    {
        Product product = productRepository.GetProductById(id);
        return productRepository.Delete(id);
    }
}