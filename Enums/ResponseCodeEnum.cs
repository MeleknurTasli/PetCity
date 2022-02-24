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