public class ProductRepository {
    public List<Product> GetAll()
    {
        return MockData.ProductMockDataList;
    }

    public Product Create(Product product)
    {
        MockData.ProductMockDataList.Add(product);
        return product;
    }

    public Product GetProductById(int id) {
        Product p = MockData.ProductMockDataList.First(x => x.ID == id);
        return p;
    }
    public Product? GetProductByName(string name)
    {
        Product? product = MockData.ProductMockDataList.FirstOrDefault(x => x.Name == name);
        return product;
    }      
    public Product? GetProductByBrand(string Brand){
        Product? product = MockData.ProductMockDataList.FirstOrDefault(x => x.Brand == Brand);
        return product;
    }

    public List<Product> GetProductOrderByName(bool IsDescending)
    {
        return IsDescending ? GetAll().OrderByDescending(x => x.Name).ToList() : GetAll().OrderBy(x => x.Name).ToList(); 
    }
    
     public List<Product> GetProductOrderByPrice(bool IsDescending)
    {
        return IsDescending ? GetAll().OrderByDescending(x => x.Price).ToList() : GetAll().OrderBy(x => x.Price).ToList(); 
    }
    public List<Product> GetProductsGreaterOrEqualsThen(decimal min) {
        return MockData.ProductMockDataList.Where(x => x.Price >= min).ToList();
    }
    public List<Product> GetProductsLessOrEqualsThen(decimal max) {
        return MockData.ProductMockDataList.Where(x => x.Price <= max).ToList();
    }
    public List<Product> GetProductsBetweenMinMaxPrice(decimal min, decimal max) {
        return MockData.ProductMockDataList.Where(x => x.Price > min && x.Price < max).ToList();
    }
    public List<Product> GetProductsInStock() {
        return MockData.ProductMockDataList.Where(x => x.Stock > 0).ToList();
    }

    public List<Product> GetProductsByCategoryName(int CategoryId){
        return MockData.ProductMockDataList.Where(x => x.CategoryId == CategoryId).ToList();
    }

    public bool Delete(int id) {
        Product product = GetProductById(id);
        return MockData.ProductMockDataList.Remove(product);
    }

    public Product Update(int id, Product product) {
        Product p = GetProductById(id);
        p = product;
        return p;
    }
}