public class ProductService : IProductService
{
    ProductRepository productRepository;
    public ProductService()
    {
       productRepository = new ProductRepository();   
    }
    public ServiceResponse<Product> Create(Product product)
    {
        ServiceResponse<Product> response = new ServiceResponse<Product>();
        var p = productRepository.GetProductByName(product.Name);

        if(p == null){
            response.ResponseCode = ResponseCodeEnum.ProductCreated;
            response.Data = productRepository.Create(product);
            return response;
        }

        response.ResponseCode = ResponseCodeEnum.DuplicateProductError;
        return response;
    }

    public ServiceResponse<List<Product>> GetAll()
    {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();

        try
        {
            response.Data = productRepository.GetAll();
            response.ResponseCode = ResponseCodeEnum.GetAllProductOperationSuccess;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAllAccountOperationFail;
            return response;
        }
    }

    public ServiceResponse<Product> GetProductByName(string name)
    {
        ServiceResponse<Product> response = new ServiceResponse<Product>();
        var product = productRepository.GetProductByName(name);
        if (product != null)
        {
            response.ResponseCode = ResponseCodeEnum.GetProductByNameOperationSuccess;
            response.Data = product;
            return response;
        }
        response.ResponseCode = ResponseCodeEnum.GetProductByNameOperationFail;
        return response;
    }
    public Product? GetProductByBrandName(string Brand){
        return productRepository.GetProductByBrand(Brand);
    }
    public List<Product> GetProductsOrderByNameDescending() {
        return productRepository.GetProductsOrderByNameDescending();
    }
    public List<Product> GetProductsOrderByNameAscending() {
        return productRepository.GetProductsOrderByNameAscending();
    }
    public List<Product> GetProductsOrderByPriceDescending() {
        return productRepository.GetProductsOrderByPriceDescending();
    }
    public List<Product> GetProductsOrderByPriceAscending() {
        return productRepository.GetProductsOrderByPriceAscending();
    }

    public List<Product> GetProductsByCategoryName(int CategoryId)
    {
        return productRepository.GetProductsByCategoryName(CategoryId);
    }

    public List<Product> GetProductsGreaterOrEqualsThen(decimal min)
    {
        return productRepository.GetProductsGreaterOrEqualsThen(min);
    }

    public List<Product> GetProductsLessOrEqualsThen(decimal max)
    {
        return productRepository.GetProductsLessOrEqualsThen(max);
    }

    public List<Product> GetProductsBetweenMinMaxPrice(decimal min, decimal max)
    {
        return productRepository.GetProductsBetweenMinMaxPrice(min, max);
    }

    public List<Product> GetProductsInStock()
    {
        return GetProductsInStock();
    }

    public List<Product> GetProductsByCategory(int CategoryId)
    {
        return productRepository.GetProductsByCategoryName(CategoryId);
    }

    public Product Update(int id, Product product)
    {
        return productRepository.Update(id, product);
    }

    public ServiceResponse<Product> Delete(int id)
    {   
        ServiceResponse<Product> response = new ServiceResponse<Product>();
        Product product = productRepository.GetProductById(id);
        response.ResponseCode = ResponseCodeEnum.ProductDeletedSuccess;
        return response;
        
    }
}