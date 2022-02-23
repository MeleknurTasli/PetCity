public interface IProductService {
    public ServiceResponse<List<Product>> GetAll();
    public List<Product> GetProductsByCategory(int CategoryId);
    public ServiceResponse<Product> Create(Product product);
    public ServiceResponse<Product> Update(int id, Product product);
    public ServiceResponse<Product> Delete(int id);
    public ServiceResponse<Product> GetProductByName(string name);
    public ServiceResponse<List<Product>> GetProductsByBrandName(string name);
    public ServiceResponse<List<Product>> GetProductsOrderByNameDescending();
    public ServiceResponse<List<Product>> GetProductsOrderByNameAscending();
    public ServiceResponse<List<Product>> GetProductsOrderByPriceDescending();
    public ServiceResponse<List<Product>> GetProductsOrderByPriceAscending();
    public List<Product> GetProductsGreaterOrEqualsThen(decimal min);
    public List<Product> GetProductsLessOrEqualsThen(decimal max);
    public List<Product> GetProductsBetweenMinMaxPrice(decimal min, decimal max);
    public ServiceResponse<List<Product>> GetProductsInStock();

}