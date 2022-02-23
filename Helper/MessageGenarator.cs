public static class MessageGenarator
{
    public static readonly Dictionary<ResponseCodeEnum, string> TrResponseMessages
        = new Dictionary<ResponseCodeEnum, string>
    {
    { ResponseCodeEnum.Success, "Ok" },
    { ResponseCodeEnum.GetAllAccountOperationSuccess,"Ok" },
    { ResponseCodeEnum.GetAllProductOperationSuccess,"Ok" },
    { ResponseCodeEnum.ProductCreated,"Ürün başarılı bir şekilde eklendi" },
     {ResponseCodeEnum.DuplicateAccountError,"Girilen e mail sistemde kayıtlı" },
     {ResponseCodeEnum.DuplicateProductError,"Girilen üründen sistemde kayıtlı" },
{ResponseCodeEnum.GetAccountByEmailOperationSuccess,"Girilen maile sahip account başarılı bir şekilde bulundu."},
{ ResponseCodeEnum.GetAccountByEmailOperationFail,"Girilen maile sahip account bulunamadı"},
{ResponseCodeEnum.GetProductByNameOperationSuccess, "Girilen isimde ürün başarılı bir şekilde bulundu"},
{ResponseCodeEnum.GetProductByNameOperationFail, "Girilen isimde ürün bulunamadı"},
{ResponseCodeEnum.GetProductsByBrandNameOperationSuccess, "Girilen markada ürün başarılı bir şekilde bulundu"},
{ResponseCodeEnum.GetProductsByBrandNameOperationFail, "Girilen markada ürün bulunamadı"},
{ResponseCodeEnum.GetProductsInStockOperationSuccess,"Stoktaki ürünler başarılı bir şekilde bulundu"},
{ResponseCodeEnum.GetProductsInStockOperationFailed,"Stoktaki ürünler bulunamadı"},
    {ResponseCodeEnum.ProductDeletedSuccess, "Ürün başarı bir şekilde silindi"},
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
    {ResponseCodeEnum.PetHelperAddFail,"Aynı Id'de veri bulundu."}


    };


    public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
    {
        return TrResponseMessages[ResponseCode];
    }

}