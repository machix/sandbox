namespace Ett.Common.Web.Validation
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http.ModelBinding;

    using ModelError = Models.ModelError;

    internal static class ModelExtensions
    {
        public static IEnumerable<ModelError> GetErrors(this ModelStateDictionary modelState)
        {
            return (from key in modelState.Keys
                    let value = modelState[key] where 
                    value.Errors.Any()
                    select new ModelError(key, value.Value.AttemptedValue, 
                        value.Errors.Select(e => e.ErrorMessage)))
                        .ToList();
        }
    }
}
