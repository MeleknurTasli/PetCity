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

    public ServiceResponse<List<Product>> GetProductsOrderByNameDescending() {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();
        response.Data = productRepository.GetProductsOrderByNameDescending();
        response.ResponseCode = ResponseCodeEnum.Success;
        return response;
    }
    public ServiceResponse<List<Product>> GetProductsOrderByNameAscending() {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();
        response.Data = productRepository.GetProductsOrderByNameAscending();
        response.ResponseCode = ResponseCodeEnum.Success;
        return response;
    }
    public ServiceResponse<List<Product>> GetProductsOrderByPriceDescending() {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();
        response.Data = productRepository.GetProductsOrderByPriceDescending();
        response.ResponseCode = ResponseCodeEnum.Success;
        return response;
    }
    public ServiceResponse<List<Product>> GetProductsOrderByPriceAscending() {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();
        response.Data = productRepository.GetProductsOrderByPriceAscending();
        response.ResponseCode = ResponseCodeEnum.Success;
        return response;
    }

    public ServiceResponse<List<Product>> GetProductsGreaterOrEqualsThan(decimal min)
    {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();
        List<Product> filteredProducts = productRepository.GetProductsGreaterOrEqualsThen(min);

        if (filteredProducts != null) {
            response.Data = filteredProducts;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }

        response.ResponseCode = ResponseCodeEnum.GetProductsGreaterThanFail;
        return response;
    }

    public ServiceResponse<List<Product>> GetProductsLessOrEqualsThan(decimal max)
    {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();
        List<Product> filteredProducts = productRepository.GetProductsLessOrEqualsThen(max);

        if (filteredProducts != null) {
            response.Data = filteredProducts;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }

        response.ResponseCode = ResponseCodeEnum.GetProductsLessThanFail;
        return response;
    }

    public ServiceResponse<List<Product>> GetProductsBetweenMinMaxPrice(decimal min, decimal max)
    {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();
        List<Product> filteredProducts = productRepository.GetProductsBetweenMinMaxPrice(min, max);

        if (filteredProducts != null) {
            response.Data = filteredProducts;
            response.ResponseCode = ResponseCodeEnum.GetProductsBetweenMinMaxPriceSuccess;
            return response;
        }

        response.ResponseCode = ResponseCodeEnum.GetProductsBetweenMinMaxPriceSuccess;
        return response;
    }

    public ServiceResponse<List<Product>> GetProductsInStock()
    {
        ServiceResponse<List<Product>> response=new ServiceResponse<List<Product>>();
        response.Data=productRepository.GetProductsInStock();
        response.ResponseCode=ResponseCodeEnum.GetProductsInStockOperationSuccess;
        return response;
    }

    public ServiceResponse<List<Product>> GetProductsByCategory(int CategoryId)
    {
        ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>();
        List<Product> filteredProducts = productRepository.GetProductsByCategory(CategoryId);
        
        if (filteredProducts != null) {
            response.Data = filteredProducts;
            response.ResponseCode = ResponseCodeEnum.GetProductsByCategorySuccess;
            return response;
        }

        response.ResponseCode = ResponseCodeEnum.GetProductsByCategoryFail;
        return response;
    }

    public ServiceResponse<Product> Update(int id, Product product)
    {   
        ServiceResponse<Product> response = new ServiceResponse<Product>();
        Product updatedProduct = productRepository.GetProductById(id);
        
        if (updatedProduct != null) {
            response.Data = productRepository.Update(id, product);
            response.ResponseCode = ResponseCodeEnum.ProductUpdatedSuccess;
            return response;
        }
        
        response.ResponseCode = ResponseCodeEnum.ProductNotFound;
        return response;
    }

    public ServiceResponse<Product> Delete(int id)
    {   
        ServiceResponse<Product> response = new ServiceResponse<Product>();
        Product product = productRepository.GetProductById(id);
        
        if (product != null) {
            productRepository.Delete(id);
            response.ResponseCode = ResponseCodeEnum.ProductDeletedSuccess;
            return response;
        }
        
        response.ResponseCode = ResponseCodeEnum.ProductNotFound;
        return response;
    }
}