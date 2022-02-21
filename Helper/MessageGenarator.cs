public static class MessageGenarator
{

    public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
    {
        switch (ResponseCode)
        {

            case ResponseCodeEnum.Success:
            case ResponseCodeEnum.GetAllAccountOperationSuccess:
                {
                    return "Ok";
                }

            case ResponseCodeEnum.DuplicateAccountError:
                {
                    return "Girilen e mail sistemde kayıtlı";
                }

            case ResponseCodeEnum.GetAccountByEmailOperationSuccess:
                {
                    return "Girilen maile sahip account başarılı bir şekilde bulundu.";
                }

            case ResponseCodeEnum.GetAccountByEmailOperationFail:
                {
                    return "Girilen maile sahip account bulunamadı";
                }
            default:
                {
                    return "blablabla";
                }
        }
    }

}