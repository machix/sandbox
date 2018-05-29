namespace Ett.Common.Web.Mvc
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using Ett.Common.DataAnnotations.Extensions;

    public sealed class CommaSeparatedModelBinder : IModelBinder
    {
        private static readonly MethodInfo ToArrayMethod = typeof(Enumerable).GetMethod("ToArray");

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var type = bindingContext.ModelType;
            if (type.GetInterface(typeof(IEnumerable).Name) == null)
            {
                return Task.CompletedTask;
            }

            var valueType = type.GetGenericType();
            if (valueType == null || valueType.GetInterface(typeof(IConvertible).Name) == null)
            {
                return Task.CompletedTask;
            }

            var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(valueType));
            var actualValue = bindingContext.ValueProvider.GetValue(bindingContext.ModelName).RawValue;
            if (actualValue == null)
            {
                return null;
            }

            foreach (var splitValue in actualValue.ToString().Split(','))
            {
                if (!string.IsNullOrWhiteSpace(splitValue))
                    list.Add(Convert.ChangeType(splitValue, valueType));
            }

            var result = type.IsArray ? ToArrayMethod.MakeGenericMethod(valueType).Invoke(this, new object[] { list }) : list;

            return result;
        }
    }
}
