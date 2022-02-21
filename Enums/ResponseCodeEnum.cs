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
    ProductNotFound,
    ProductDeletedSuccess,
    GetAllProductOperationSuccess,
    GetAllProductOperationFail,
    BadRequest = 400,
}