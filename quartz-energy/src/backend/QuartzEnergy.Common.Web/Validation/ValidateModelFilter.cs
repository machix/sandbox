namespace QuartzEnergy.Common.Web.Validation
{
    using QuartzEnergy.Common.Web.Extensions;
    using QuartzEnergy.Common.Web.Models;

    using Microsoft.AspNetCore.Mvc.Filters;

    public sealed class ValidateModelFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
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
