public interface IProductService{
    Product AddProduct(Product product);
    Product UpdateProduct(int id, Product product);
    void DeleteProduct(Product product);
    List<Product> GetAllProduct();
    Product GetByProductId(int productId);
    List<Product> GetAllProductByName(string productName);
    List<Product> GetAllProductByCategoryId(int categoryId);
    List<Product> GetAllProductByBrandId(int brandId);
    List<Product> GetAllProductByPriceASC(int price);
    List<Product> GetAllProductByPriceDESC(int price);
    List<Product> GetAllProductByPriceRange(int minPrice , int maxPrice);
    

}