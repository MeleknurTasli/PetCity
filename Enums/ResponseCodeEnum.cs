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
    GetPetByGenusOperationSuccess,
    GetAllPetOperationFail,
    DuplicatePetError,
    PetIDNotFoundError,
    GetPetByGenusOperationFail,


    

    BadRequest = 400,
    

}