namespace Ett.Common.Web.Validation
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http.Filters;

    using Ett.Common.Web.Models;

    public sealed class ModelErrorsFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (!(context.Exception is InvalidModelException))
            {
                throw context.Exception;
            }

            var modelException = (InvalidModelException)context.Exception;

            context.Response = context.Request.CreateResponse(
                HttpStatusCode.BadRequest,
                modelException.Errors,
                "application/json");
        }
    }
}
