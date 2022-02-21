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
    GetAllPetOperationFail,
    DuplicatePetError,
    PetIDNotFoundError,


    

    BadRequest = 400,
}