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
    GetPetByIDOperationOperationSuccess,
    GetAllPetOperationSuccess,
    GetAllPetOperationFail,
    DuplicatePetError,
    PetIDNotFoundError,


    

    BadRequest = 400,
}