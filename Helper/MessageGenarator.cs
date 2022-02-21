public static class MessageGenarator
{
    public static readonly Dictionary<ResponseCodeEnum, string> TrResponseMessages
        = new Dictionary<ResponseCodeEnum, string>
    {
    { ResponseCodeEnum.Success, "Ok" },
    { ResponseCodeEnum.GetAllAccountOperationSuccess,"Ok" },
    {ResponseCodeEnum.DuplicateAccountError,"Girilen e mail sistemde kayıtlı" },
    {ResponseCodeEnum.GetAccountByEmailOperationSuccess,"Girilen maile sahip account başarılı bir şekilde bulundu."},
    { ResponseCodeEnum.GetAccountByEmailOperationFail,"Girilen maile sahip account bulunamadı"},
    //Pet Operation
    { ResponseCodeEnum.GetPetByIDOperationFail,"Girilen id'ye sahip pet bulunamadı"},
    { ResponseCodeEnum.GetPetByIDOperationSuccess,"Ok"},
    { ResponseCodeEnum.GetAllPetOperationSuccess,"Ok"},
    { ResponseCodeEnum.GetAllPetOperationFail,"Petler Getirelemedi"},
    { ResponseCodeEnum.DuplicatePetError,"Aynı id'ye sahip pet bulunmaktadır."},
    { ResponseCodeEnum.PetIDNotFoundError,"Girilen id'ye sahip pet bulunamadı"},





    };


    public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
    {
        return TrResponseMessages[ResponseCode];
    }

}