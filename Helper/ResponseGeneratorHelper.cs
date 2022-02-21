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
            case ResponseCodeEnum.GetProductByNameOperationSuccess:
                {
                    return Ok(incomingResponse);
                }

            case ResponseCodeEnum.GetAccountByEmailOperationFail:
            case ResponseCodeEnum.GetProductByNameOperationFail:
                {
                    return NotFound(incomingResponse);
                }
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