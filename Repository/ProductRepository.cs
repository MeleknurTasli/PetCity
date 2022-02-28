public class ProductRepository : IProductRepository
{
    private readonly PetCityContext _context;

    public ProductRepository(PetCityContext context)
    {
        _context=context;
    }
    public async Task<Product> AddProduct(Product product)
    {
        using(_context)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }

    public async Task DeleteProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Product>> GetAllProduct()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Product>> GetAllProductByBrandId(int brandId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Product>> GetAllProductByCategoryId(int categoryId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Product>> GetAllProductByName(string productName)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Product>> GetAllProductByPriceASC(int price)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Product>> GetAllProductByPriceDESC(int price)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Product>> GetAllProductByPriceRange(int minPrice, int maxPrice)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetByProductId(int productId)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> UpdateProduct(int id, Product product)
    {
        throw new NotImplementedException();
    }
}