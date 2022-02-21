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
    GetAllPetOperationFail,
    DuplicatePetError,
    PetIDNotFoundError,


    

    BadRequest = 400,
    

}