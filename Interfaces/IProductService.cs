public interface IProductService {
    public List<Product> GetAll();
    public List<Product> GetProductsByCategory(int CategoryId);
    public Product Create(Product product);
    public Product? GetProductByName(string name);
    public Product? GetProductByBrandName(string name);
    public List<Product> GetProductOrderByName(bool IsDescending);
    public List<Product> GetProductOrderByPrice(bool IsDescending);
    public List<Product> GetProductsGreaterThen(decimal min);
    public List<Product> GetProductsLessThen(decimal max);
    public List<Product> GetProductsBetweenMinMaxPrice(decimal min, decimal max);
    public List<Product> GetProductsInStock();

}