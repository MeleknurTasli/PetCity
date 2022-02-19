public interface IProductService {
    public List<Product> GetAll();
    public Product Create(Product product);
    public Product? GetProductByName(string name);
}