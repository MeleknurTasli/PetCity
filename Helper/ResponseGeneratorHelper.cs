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
            case ResponseCodeEnum.GetAllPetHelperSuccess:
            case ResponseCodeEnum.FindPetHelperByLatLongSuccess:
                {
                    return Ok(incomingResponse);
                }

            case ResponseCodeEnum.GetAccountByEmailOperationFail:
                {
                    return NotFound(incomingResponse);
                }
                case ResponseCodeEnum.GetAllPetHelperFail:
                case ResponseCodeEnum.FindPetHelperByLatLongFail:
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