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
{ResponseCodeEnum.GetAllPetHelperSuccess,"Ok"},
{ResponseCodeEnum.GetAllPetHelperFail,"Pethelper bulunamadı."}

    };


    public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
    {
        return TrResponseMessages[ResponseCode];
    }

}