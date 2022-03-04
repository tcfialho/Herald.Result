using Microsoft.AspNetCore.Mvc;

using System.Net;
using System.Threading.Tasks;

namespace Herald.Result.Mvc
{
    public static class HeraldToActionResultExtensions
    {
        public static async Task<IActionResult> ToActionResult(this Task<Result> taskResult, HttpStatusCode onSucess = HttpStatusCode.OK, HttpStatusCode onFail = HttpStatusCode.BadRequest)
        {
            var result = await taskResult;

            switch (result.Status)
            {
                case Status.Fail:
                    return new ObjectResult(new { result.Message }) { StatusCode = (int)onFail };
                case Status.NotFound:
                    return new NotFoundObjectResult(new { result.Message });
            }

            return new StatusCodeResult((int)onSucess);
        }

        public static async Task<IActionResult> ToActionResult<T>(this Task<Result<T>> taskResult, HttpStatusCode onSucess = HttpStatusCode.OK, HttpStatusCode onFail = HttpStatusCode.BadRequest) where T : class
        {
            var result = await taskResult;

            switch (result.Status)
            {
                case Status.Fail:
                    return new ObjectResult(new { result.Message }) { StatusCode = (int)onFail };
                case Status.NotFound:
                    return new NotFoundObjectResult(new { result.Message });
            }

            return new ObjectResult(result.Data) { StatusCode = (int)onSucess };
        }
    }
}
