using Microsoft.AspNetCore.Mvc;

public class ResponseGeneratorHelper : ControllerBase
{
    public ActionResult ResponseGenerator<T>(ServiceResponse<T> incomingResponse)
    {
        switch (incomingResponse.ResponseCode)
        {
            case ResponseCodeEnum.Success:
            case ResponseCodeEnum.AccountCreated:
            case ResponseCodeEnum.GetAllAccountOperationSuccess:
            case ResponseCodeEnum.GetAccountByEmailOperationSuccess:
            case ResponseCodeEnum.GetPetByIDOperationSuccess:
            case ResponseCodeEnum.GetAllPetOperationSuccess:
            ////////////////////Pethelper start here////////////////////////////
            case ResponseCodeEnum.GetAllPetHelperSuccess:
            case ResponseCodeEnum.FindPetHelperByLatLongSuccess:
            case ResponseCodeEnum.PetHelperGetByIdSuccess:
            case ResponseCodeEnum.PetHelperAddSuccess:
            case ResponseCodeEnum.PetHelperUpdateSuccess:
            case ResponseCodeEnum.GetPetHelperDeleteSuccess:
            ///////////////////////Pethelper end here///////////////////////////////
            

                {
                    return Ok(incomingResponse);
                }

            case ResponseCodeEnum.GetAccountByEmailOperationFail:
            case ResponseCodeEnum.GetPetByIDOperationFail:
            case ResponseCodeEnum.GetAllPetOperationFail:
            case ResponseCodeEnum.DuplicateAccountError:
            case ResponseCodeEnum.PetIDNotFoundError:
                {
                    return NotFound(incomingResponse);
                }
                case ResponseCodeEnum.GetAllPetHelperFail:
                case ResponseCodeEnum.FindPetHelperByLatLongFail:
                case ResponseCodeEnum.PetHelperAddFail:
                case ResponseCodeEnum.PetHelperGetByIdFail:
                case ResponseCodeEnum.PetHelperUpdateFail:
                case ResponseCodeEnum.GetPetHelperDeleteFail:
                {
                    return NotFound(incomingResponse);
                }
            default:
                {
                    return BadRequest(incomingResponse);
                }
        }
    }
}