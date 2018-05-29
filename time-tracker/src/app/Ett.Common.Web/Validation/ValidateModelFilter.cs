namespace Ett.Common.Web.Validation
{
    using System.Web.Http.Controllers;

    using Ett.Common.Web.Models;

    using ActionFilterAttribute = System.Web.Http.Filters.ActionFilterAttribute;

    public sealed class ValidateModelFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext context)
        {
            var modelState = context.ModelState;
            if (!modelState.IsValid)
            {
                throw new InvalidModelException(modelState.GetErrors());
            }

            base.OnActionExecuting(context);
        }
    }
}
