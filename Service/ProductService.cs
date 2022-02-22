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

    public ServiceResponse<List<Product>> GetProductsByBrandName(string name)
    {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();
        var products = productRepository.GetProductsByBrandName(name);
        if (products != null)
        {
            response.ResponseCode = ResponseCodeEnum.GetProductsByBrandNameOperationSuccess;
            response.Data = products;
            return response;
        }
        response.ResponseCode = ResponseCodeEnum.GetProductsByBrandNameOperationFail;
        return response;
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

    public ServiceResponse<Product> Update(int id, Product product)
    {   ServiceResponse<Product> response = new ServiceResponse<Product>();
        productRepository.Update(id, product);
        response.ResponseCode = ResponseCodeEnum.ProductUpdatedSuccess;
        return response;
    }

    public ServiceResponse<Product> Delete(int id)
    {   
        ServiceResponse<Product> response = new ServiceResponse<Product>();
        productRepository.Delete(id);
        response.ResponseCode = ResponseCodeEnum.ProductDeletedSuccess;
        return response;
        
    }

    public ServiceResponse<Product> GetProductByName(string name)
    {
        throw new NotImplementedException();
    }
}