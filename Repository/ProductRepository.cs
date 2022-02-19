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

    public Product? GetProductByName(string name)
    {
        Product? product = MockData.ProductMockDataList.FirstOrDefault(x => x.Name == name);
        return product;
    }      
    public Product? GetProductByBrand(string Brand){
        Product? product = MockData.ProductMockDataList.FirstOrDefault(x => x.Brand == Brand);
        return product;
    }
    
     public List<Product> GetProductOrderByPrice(bool IsDescending)
    {
        return IsDescending ? GetAll().OrderByDescending(x => x.Price).ToList() : GetAll(); 
    }
}