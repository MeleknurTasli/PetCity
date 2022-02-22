public enum ResponseCodeEnum
{
    Success,
    DuplicateAccountError,
    UserNotFound,
    AccountCreated,
    GetAllAccountOperationSuccess,
    GetAllAccountOperationFail,
    GetAccountByEmailOperationSuccess,
    GetAccountByEmailOperationFail,
    GetProductByNameOperationSuccess,
    GetProductByNameOperationFail,
    GetProductsByBrandNameOperationSuccess,
    GetProductsByBrandNameOperationFail,
    ProductNotFound,
    ProductDeletedSuccess,
    GetAllProductOperationSuccess,
    GetAllProductOperationFail,
    DuplicateProductError,
    ProductCreated,
    BadRequest = 400,
}