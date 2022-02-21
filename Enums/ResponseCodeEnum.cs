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

    //PetHelper
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



    

    BadRequest = 400,
    

}