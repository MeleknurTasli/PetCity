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
    GetProductsByCategorySuccess,
    GetProductsByCategoryFail,
    GetProductsBetweenMinMaxPriceSuccess,
    GetProductsBetweenMinMaxPriceFail,
    ProductNotFound,
    ProductUpdatedSuccess,
    ProductDeletedSuccess,
    GetAllProductOperationSuccess,
    GetAllProductOperationFail,
    DuplicateProductError,
    ProductCreated,
    GetProductsGreaterThanFail,
    GetProductsLessThanFail,
    BadRequest = 400,
    GetAllPetHelperSuccess,
    GetAllPetHelperFail,
    FindPetHelperByLatLongSuccess,
    FindPetHelperByLatLongFail,
    PetHelperAddSuccess,
    PetHelperAddFail,
    PetHelperGetByIdSuccess,
    PetHelperGetByIdFail,
    PetHelperUpdateSuccess,
    PetHelperUpdateFail,
    GetPetHelperDeleteSuccess,
    GetPetHelperDeleteFail,


    //PetHelper end here

    //pet Operations
    GetPetByIDOperationFail,
    GetPetByIDOperationSuccess,
    GetAllPetOperationSuccess,
    GetAllPetOperationFail,
    DuplicatePetError,
    PetIDNotFoundError,



    
    

}