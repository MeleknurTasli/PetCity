public interface IProductService {
    public ServiceResponse<List<Product>> GetAll();
    public List<Product> GetProductsByCategory(int CategoryId);
    public Product? Create(Product product);
    public Product Update(int id, Product product);
    public ServiceResponse<Product> Delete(int id);
    public ServiceResponse<Product> GetProductByName(string name);
    public Product? GetProductByBrandName(string name);
    public List<Product> GetProductsOrderByNameDescending();
    public List<Product> GetProductsOrderByNameAscending();
    public List<Product> GetProductsOrderByPriceDescending();
    public List<Product> GetProductsOrderByPriceAscending();
    public List<Product> GetProductsGreaterOrEqualsThen(decimal min);
    public List<Product> GetProductsLessOrEqualsThen(decimal max);
    public List<Product> GetProductsBetweenMinMaxPrice(decimal min, decimal max);
    public List<Product> GetProductsInStock();

}