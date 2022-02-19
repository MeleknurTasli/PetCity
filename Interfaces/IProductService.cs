public interface IProductService {
    public List<Product> GetAll();
    public List<Product> GetProductsByCategoryName(int CategoryId);
    public Product Create(Product product);
    public Product? GetProductByName(string name);
    public Product? GetProductByBrand(string Brand);
    public List<Product> GetProductOrderByPrice(bool IsDescending);
    public List<Product> GetProductsGreaterThen(decimal min);
    public List<Product> GetProductsLessThen(decimal max);
    public List<Product> GetProductsBetweenMinMaxPrice(decimal min, decimal max);
    public List<Product> GetProductsInStock();

}