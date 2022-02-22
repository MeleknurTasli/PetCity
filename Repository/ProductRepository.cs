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

    public Product? GetProductByNameAndBrandName(string name, string brand){
        Product? product = MockData.ProductMockDataList.FirstOrDefault(x => x.Name == name && x.Brand == brand);
        return product;
    }

    public List<Product> GetProductsOrderByNameDescending() {
        return GetAll().OrderByDescending(x => x.Name).ToList();
    }

     public List<Product> GetProductsOrderByNameAscending() {
        return GetAll().OrderBy(x => x.Name).ToList();
    }
    
     public List<Product> GetProductsOrderByPriceDescending() {
        return GetAll().OrderByDescending(x => x.Price).ToList(); 
    }

    public List<Product> GetProductsOrderByPriceAscending() {
        return GetAll().OrderBy(x => x.Price).ToList(); 
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

    public void Delete(int id) {
        MockData.ProductMockDataList.Remove(GetProductById(id));      
    }

    public Product Update(int id, Product product) {
        Product p = GetProductById(id);
        p.Name = product.Name;
        p.Brand = product.Brand;
        p.Detail = product.Detail;
        p.Price = product.Price;
        p.Stock = product.Stock;
        return p;
    }
}