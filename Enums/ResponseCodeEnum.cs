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
    //Product Enums
    GetProductByNameOperationSuccess,
    GetProductByNameOperationFail,
    GetProductsByBrandNameOperationSuccess,
    GetProductsByBrandNameOperationFail,
    GetProductsInStockOperationSuccess,
    GetProductsInStockOperationFailed,
    ProductNotFound,
    ProductUpdatedSuccess,
    ProductDeletedSuccess,
    GetAllProductOperationSuccess,
    GetAllProductOperationFail,
    DuplicateProductError,
    ProductCreated,
    BadRequest = 400,
    GetAllPetHelperSuccess,
    GetAllPetHelperFail,
    FindPetHelperByLatLongSuccess,
    FindPetHelperByLatLongFail,
    PetHelperAddSuccess,
    PetHelperAddFail,

    //pet Operations
    GetPetByIDOperationFail,
    GetPetByIDOperationSuccess,
    GetAllPetOperationSuccess,
    GetAllPetOperationFail,
    DuplicatePetError,
    PetIDNotFoundError,


    
    

}