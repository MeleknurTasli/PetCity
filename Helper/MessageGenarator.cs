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
    {ResponseCodeEnum.GetAllPetHelperSuccess,"Ok"},
    {ResponseCodeEnum.GetAllPetHelperFail,"Pethelper bulunamadı."},
    {ResponseCodeEnum.FindPetHelperByLatLongSuccess,"Koordinat bulundu."},
    {ResponseCodeEnum.FindPetHelperByLatLongFail,"Koordinat bulunamadı."},
    {ResponseCodeEnum.PetHelperAddSuccess,"Ok"},
    {ResponseCodeEnum.PetHelperAddFail,"Aynı Id'de veri bulundu."},
    {ResponseCodeEnum.PetHelperGetByIdSuccess, "Ok"},
    {ResponseCodeEnum.PetHelperGetByIdFail, "Verilen Id'ye ait PetHelper bulunamadı."},
    {ResponseCodeEnum.PetHelperUpdateSuccess, "Ok"},
    {ResponseCodeEnum.PetHelperUpdateFail,"Güncellenecek veri bulunamadı."},
    {ResponseCodeEnum.GetPetHelperDeleteSuccess,"ok"},
    {ResponseCodeEnum.GetPetHelperDeleteFail,"Silinecek Veri Bulunamadı"}






    };


    public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
    {
        return TrResponseMessages[ResponseCode];
    }

}