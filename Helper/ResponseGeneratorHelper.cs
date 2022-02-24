using Microsoft.AspNetCore.Mvc;

public class ResponseGeneratorHelper : ControllerBase
{
    public ActionResult ResponseGenerator<T>(ServiceResponse<T> incomingResponse)
    {
        switch (incomingResponse.ResponseCode)
        {
            case ResponseCodeEnum.Success:
            case ResponseCodeEnum.AccountCreated:
            case ResponseCodeEnum.ProductCreated:
            case ResponseCodeEnum.GetAllAccountOperationSuccess:
            case ResponseCodeEnum.GetAllProductOperationSuccess:
            case ResponseCodeEnum.GetAccountByEmailOperationSuccess:
            case ResponseCodeEnum.GetPetByIDOperationSuccess:
            case ResponseCodeEnum.GetAllPetOperationSuccess:
            case ResponseCodeEnum.GetAllPetHelperSuccess:
            case ResponseCodeEnum.FindPetHelperByLatLongSuccess:
            case ResponseCodeEnum.PetHelperGetByIdSuccess:
            case ResponseCodeEnum.PetHelperAddSuccess:
            case ResponseCodeEnum.PetHelperUpdateSuccess:
            case ResponseCodeEnum.GetPetHelperDeleteSuccess:
            case ResponseCodeEnum.GetProductByNameOperationSuccess:
            case ResponseCodeEnum.GetProductsByBrandNameOperationSuccess:
            case ResponseCodeEnum.GetProductsInStockOperationSuccess:
            case ResponseCodeEnum.ProductDeletedSuccess:
            case ResponseCodeEnum.GetProductsByCategorySuccess:
            case ResponseCodeEnum.GetProductsBetweenMinMaxPriceSuccess:
                {
                    return Ok(incomingResponse);
                }

            case ResponseCodeEnum.GetAccountByEmailOperationFail:
            case ResponseCodeEnum.GetProductByNameOperationFail:
            case ResponseCodeEnum.GetProductsByBrandNameOperationFail:
            case ResponseCodeEnum.GetProductsInStockOperationFailed:
            case ResponseCodeEnum.GetPetByIDOperationFail:
            case ResponseCodeEnum.GetAllPetOperationFail:
            case ResponseCodeEnum.DuplicateAccountError:
            case ResponseCodeEnum.PetIDNotFoundError:
            case ResponseCodeEnum.ProductNotFound:
            case ResponseCodeEnum.GetAllPetHelperFail:
            case ResponseCodeEnum.FindPetHelperByLatLongFail:
            case ResponseCodeEnum.GetProductsGreaterThanFail:
            case ResponseCodeEnum.GetProductsLessThanFail:
            case ResponseCodeEnum.GetProductsByCategoryFail:
            case ResponseCodeEnum.GetProductsBetweenMinMaxPriceFail:
                {
                    return NotFound(incomingResponse);
                }
                case ResponseCodeEnum.PetHelperAddFail:
                case ResponseCodeEnum.PetHelperGetByIdFail:
                case ResponseCodeEnum.PetHelperUpdateFail:
                case ResponseCodeEnum.GetPetHelperDeleteFail:
            case ResponseCodeEnum.GetAllProductOperationFail:
                {
                    return NoContent();
                }
            default:
                {
                    return BadRequest(incomingResponse);
                }
        }
    }
}