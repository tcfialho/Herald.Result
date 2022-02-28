using System.Net;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Herald.Result.Mvc
{
    public static class HeraldToActionResultExtensions
    {
        public static async Task<IActionResult> ToActionResult(this Task<Result> taskResult, HttpStatusCode onSucess = HttpStatusCode.OK, HttpStatusCode onFail = HttpStatusCode.BadRequest)
        {
            var result = await taskResult;

            switch (result)
            {
                case NotFound notfound:
                    return new NotFoundObjectResult(new { notfound.Message });
                case Fail fail:
                    return new ObjectResult(new { fail.Message }) { StatusCode = (int)onFail };
                case Sucess sucess when !sucess.HasValue():
                    return new StatusCodeResult((int)onSucess);
            }

            return new OkObjectResult(result.GetValue());
        }

        public static async Task<IActionResult> ToActionResult<T>(this Task<Result<T>> taskResult, HttpStatusCode onSucess = HttpStatusCode.OK, HttpStatusCode onFail = HttpStatusCode.BadRequest) where T : class
        {
            var result = await taskResult;

            switch (result)
            {
                case NotFound notfound:
                    return new NotFoundObjectResult(new { notfound.Message });
                case Fail fail:
                    return new ObjectResult(new { fail.Message }) { StatusCode = (int)onFail };
            }

            return new ObjectResult(result.GetValue()) { StatusCode = (int)onSucess };
        }
    }
}
