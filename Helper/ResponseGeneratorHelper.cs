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
            default:
                {
                    return BadRequest(incomingResponse);
                }
        }
    }
}