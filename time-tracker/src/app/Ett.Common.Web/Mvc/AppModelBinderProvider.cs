namespace Ett.Common.Web.Mvc
{
    using System;
    using System.Web.Mvc;

    using Ett.Common.DataAnnotations.Extensions;

    public sealed class AppModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(Type modelType)
        {
            if (modelType.IsPrimitiveGeneric())
                return new CommaSeparatedModelBinder();

            return null;
        }
    }
}
